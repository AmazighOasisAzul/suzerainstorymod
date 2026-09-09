# Translation Status

Translations are completed content-unit by content-unit, never as an afterthought.

## Current completed unit

| Content unit | English keys | Required catalogs | Status |
|---|---:|---:|---|
| `civic-listening-tour` | 6 | `es-ES`, `fr`, `eo`, `zh-CN`, `ar`, `ru`, `hi`, `ja`, `ko` | Complete (54 translated strings) |

The English catalog is the source and is not counted as a translation. Every required catalog currently has the same six non-empty keys.

## Required delivery order

1. European Spanish (`es-ES`)
2. French (`fr`)
3. Esperanto (`eo`)
4. Simplified Chinese (`zh-CN`)
5. Arabic (`ar`)
6. Russian (`ru`)
7. Hindi (`hi`)
8. Japanese (`ja`)
9. Korean (`ko`)

## Translation gate for new content

Before a story, decision, event, character, Codex entry, or interface text is considered complete:

1. Its English source catalog and stable keys must exist.
2. All nine required catalogs must contain the same non-empty keys in the order above.
3. `tools/Test-Localization.ps1` must pass.
4. Political terminology, proper names, and character voice still require human review before a public release.

No untranslated content is currently waiting in the repository. Future content must enter this workflow before it moves on to implementation or release.
