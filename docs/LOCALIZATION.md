# Localization

## Objective

Localization is a core part of the project, not a final optional patch. The first priority is major world languages with large potential player populations.

## Planned languages

| Code | Language | Status |
|---|---|---|
| `en` | English | Source |
| `es` | Spanish | Planned |
| `zh-CN` | Simplified Chinese | Planned |
| `hi` | Hindi | Planned |
| `ar` | Arabic | Planned |
| `pt-BR` | Brazilian Portuguese | Planned |
| `ru` | Russian | Planned |
| `ja` | Japanese | Planned |
| `de` | German | Planned |
| `fr` | French | Planned |
| `it` | Italian | Planned |
| `ko` | Korean | Planned |

## Rules

- Source text receives a stable key.
- Translations reference that key rather than copying source files into language-specific identifiers.
- Variables and formatting tokens must be preserved exactly unless the implementation explicitly allows translation-specific syntax.
- New source keys should be reported before translation begins.
- Removed or renamed keys should be tracked so obsolete translations can be detected.
- Machine translation may assist drafting, but final releases require human review for political terminology, names, tone, and consistency.

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
