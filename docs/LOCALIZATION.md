# Localization

## Objective

Localization is a core part of the project, not a final optional patch. The first priority is major world languages with large potential player populations.

## Planned languages

| Code | Language | Status |
|---|---|---|
| `en` | English | Source |
| `es-ES` | European Spanish | Starter catalog complete |
| `fr` | French | Starter catalog complete |
| `eo` | Esperanto | Starter catalog complete |
| `zh-CN` | Simplified Chinese | Starter catalog complete |
| `ar` | Arabic | Starter catalog complete |
| `ru` | Russian | Starter catalog complete |
| `hi` | Hindi | Starter catalog complete |
| `ja` | Japanese | Starter catalog complete |
| `ko` | Korean | Starter catalog complete |

## Rules

- Source text receives a stable key.
- Translations reference that key rather than copying source files into language-specific identifiers.
- Variables and formatting tokens must be preserved exactly unless the implementation explicitly allows translation-specific syntax.
- New source keys should be reported before translation begins.
- Removed or renamed keys should be tracked so obsolete translations can be detected.
- Machine translation may assist drafting, but final releases require human review for political terminology, names, tone, and consistency.

## Catalog layout and mapping

Each locale has a JSON catalog for a content unit, for example:

```text
localization/en/civic-listening-tour.json
localization/es-ES/civic-listening-tour.json
```

English (`en`) is the canonical key set. A content unit records its localization namespace in its content document; the first decision does so in `content/decisions/civic-listening-tour.md` and uses `decision.civic_listening_tour.*`. Every translated catalog must have exactly the English catalog's keys. Keep keys stable after publication; change the value, not the identifier.

Run `tools/Test-Localization.ps1` from the repository root to compare all current catalogs against the English source and reject missing, extra, empty, or malformed entries.

The current JSON catalogs are source assets. They do not yet connect to a documented runtime localization API in SMK; that adapter will be added only after it is verified against the target game and Kit version.

## Completion gate

The project completes translations per content unit before treating that unit as ready for further implementation or release. See `localization/STATUS.md` for the required language order, audited coverage, and definition of complete. At present, the Civic Listening Tour is the only written content unit and is complete in every target locale.

## Quality checks

A localization build should check for:

- Missing keys
- Extra keys
- Duplicate keys
- Broken formatting tokens
- Invalid characters for the target format
- Untranslated source text where translation is required

## Terminology

A shared glossary should be maintained once implementation begins. Political parties, institutions, countries, titles, laws, and recurring terminology should have consistent translations across the entire mod.
