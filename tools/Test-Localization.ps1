[CmdletBinding()]
param(
    [string]$LocalizationRoot
)

if ([string]::IsNullOrWhiteSpace($LocalizationRoot)) {
    $LocalizationRoot = Join-Path $PSScriptRoot "..\localization"
}

function Read-Catalog([string]$Path) {
    $json = Get-Content -Raw -Encoding UTF8 $Path | ConvertFrom-Json
    $catalog = @{}
    $json.PSObject.Properties | ForEach-Object { $catalog[$_.Name] = [string]$_.Value }
    Write-Output -NoEnumerate $catalog
}

$sourcePath = Join-Path $LocalizationRoot "en\civic-listening-tour.json"
$source = Read-Catalog $sourcePath
$sourceKeys = @($source.Keys | Sort-Object)
$failures = @()

Get-ChildItem -Directory $LocalizationRoot | Where-Object Name -ne 'en' | ForEach-Object {
    $path = Join-Path $_.FullName "civic-listening-tour.json"
    if (-not (Test-Path -LiteralPath $path)) {
        $failures += "$($_.Name): missing civic-listening-tour.json"
        return
    }

    try {
        $catalog = Read-Catalog $path
        $keys = @($catalog.Keys | Sort-Object)
        $missing = Compare-Object $sourceKeys $keys -PassThru | Where-Object SideIndicator -eq '<='
        $extra = Compare-Object $sourceKeys $keys -PassThru | Where-Object SideIndicator -eq '=>'
        if ($missing) { $failures += "$($_.Name): missing keys: $($missing -join ', ')" }
        if ($extra) { $failures += "$($_.Name): extra keys: $($extra -join ', ')" }
        foreach ($key in $sourceKeys) {
            if ([string]::IsNullOrWhiteSpace($catalog[$key])) {
                $failures += "$($_.Name): empty value for $key"
            }
        }
    } catch {
        $failures += "$($_.Name): invalid JSON ($($_.Exception.Message))"
    }
}

if ($failures.Count -gt 0) {
    $failures | ForEach-Object { Write-Error $_ }
    exit 1
}

Write-Host "Localization catalogs match the English source keys."
