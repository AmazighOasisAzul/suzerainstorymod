# Modding Technical Notes

This document records verified technical information about modifying Suzerain.

## Verification status

**Not yet established:**

- Target game version
- Story data format
- Event/decision format
- Codex data format
- Localization format
- Runtime or executable architecture relevant to mod loading
- Required mod loader/framework
- Packaging and installation format

These must be determined from the actual game files and tested before engine-specific implementation is committed.

## First technical milestone

The first implementation milestone is a minimal, reversible modification that changes one known piece of text and can be loaded successfully in the target game.

After that milestone, the project can safely build tooling around the real data structures instead of guessing them.

## Evidence standard

When documenting a technical discovery, record:

- Game version
- File/path examined
- Format or structure discovered
- Tool used to inspect it
- Modification made
- Test result
- Compatibility limitations

This file should become the technical reference for contributors as the mod develops.
