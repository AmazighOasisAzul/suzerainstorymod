# Modding Technical Notes

This document records verified technical information about modifying Suzerain.

## Verified development foundation

The official **Suzerain Modding Kit (SMK)** documentation and its maintained `DecisionExample` project establish this project's current implementation path:

- Suzerain mods are C# .NET 6 class libraries loaded by MelonLoader.
- The current project target is the Steam version of Suzerain on Windows. Linux is out of scope for this mod even though SMK itself also documents Proton support.
- A mod identifies itself with `MelonInfo` and `MelonGame` assembly attributes and extends `MelonMod`.
- SMK exposes `Events.OnEvaluateStep`, `Events.OnDecisionShow`, and `Events.OnDecisionFinished` for a custom decision.
- `Variables.Register` registers persistent custom state, and `GameState.AddCustomStoryFragment` adds a `CustomDecisionFragment`.
- SMK's currently documented target Suzerain build is `3.1.0.1.175`; the installed game must be checked before compatibility is claimed.

The repository's first implementation is `src/SuzerainStoryMod`. It follows the documented decision-example structure and adds the isolated **Civic Listening Tour** fragment at Sordland turn 1, step 2. The code is intentionally limited to APIs demonstrated in the official example.

### Deliberately not yet verified

- The local target game version and installation path
- A successful DLL build against the user's installed game assemblies
- In-game loading and behavior
- A supported SMK API for loading localization catalogs or switching text by the game's selected language
- Story, Codex, and base-game localization data formats

No in-game test has been performed or claimed.

## Local setup and build

1. Install MelonLoader and place `SuzerainModdingKit.dll` in the game's `Mods` directory, following the official SMK installation guide.
2. Create an untracked `src/SuzerainStoryMod/Directory.Build.props` containing the installed game's path:

```xml
<Project>
  <PropertyGroup>
    <GamePath>C:\Program Files (x86)\Steam\steamapps\common\Suzerain</GamePath>
  </PropertyGroup>
</Project>
```

3. Build the project using the `Debug`/`x64` configuration. When the `Mods` directory exists, the project copies its DLL there after a successful build.

The project fails clearly if `GamePath` has not been supplied, rather than silently compiling against unknown assemblies.

## Android boundary

Android is a future target, but it is not a build output of this C# project. The Android game is an IL2CPP APK and needs its own compatible integration and testing workflow. Do not use a third-party repackaged APK as the baseline for Android development. The separate requirements are recorded in `docs/PLATFORMS.md`.

## Localization boundary

SMK's public guides document direct string parameters for decisions and dialogue, but do not document a mod-local localization loader. The JSON catalogs under `localization/` are therefore source-controlled translation assets, not a statement that runtime language switching works today. The implementation uses the English source strings until that integration point is verified.

## First technical milestone

The first implementation milestone is a minimal, reversible modification that adds one isolated decision and can be loaded successfully in the target game.

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
