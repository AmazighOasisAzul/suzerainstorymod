# Contributing

## Scope

This project expands Suzerain with additional story content, turns, decisions, events, Codex material, fixes, and major-language localization.

## Before changing content

- Check the existing documentation and content structure.
- Do not assume undocumented game behavior.
- Identify the target game version and the relevant base-game data before making engine-specific changes.
- Keep unrelated changes separate.

## Story content

New story content should document:

- The turn or event where it appears.
- Trigger conditions.
- Choices presented to the player.
- Variables or previous decisions that affect it.
- Consequences.
- Any Codex entries or localization keys it introduces.

## Codex

Codex entries should be factual within the game's setting and consistent with established terminology. New entries should use stable identifiers so translations can reference the same source entry.

## Localization

Do not edit translated text as if it were source English. Update the source text first, then update translations against the changed source keys.

## Bug fixes

A fix should identify the original issue, the affected version, the intended behavior, and how the fix was tested.

## Commits

Use concise commit messages that describe the change, for example:

- `story: add first post-campaign event`
- `codex: add constitutional court entry`
- `fix: correct missing event condition`
- `i18n: add Spanish source structure`
- `docs: document event format`

## Pull requests

A pull request should explain what changed, what was tested, and any known limitations.
