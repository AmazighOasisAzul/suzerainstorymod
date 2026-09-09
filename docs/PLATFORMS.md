# Platform Scope

Suzerain Story Mod targets only these platforms:

| Platform | Target | Current implementation path | Status |
|---|---|---|---|
| Windows | Steam PC release | C# + MelonLoader + Suzerain Modding Kit | Starter project present; untested |
| Android | Official Android release | Separate Android Unity IL2CPP integration | Research required; not implemented |

Linux and macOS are explicitly out of scope for this project.

## Why there are two paths

The Windows build is a managed MelonLoader mod and is represented by `src/SuzerainStoryMod`. The Android release is a Unity IL2CPP application packaged as an APK. A Windows DLL cannot be copied into an Android APK and made to run; Android support will need its own compatible loader/integration, packaging, signing, device testing, and update-compatibility process.

The Android APK supplied for reference confirms the IL2CPP/Addressables architecture, but it is a third-party modified build. It is not a trusted development baseline and must not be redistributed, used to bypass licensing, or treated as proof that our mod works on Android.

## Required gates

### Windows

1. A legitimate Steam installation of Suzerain at the version supported by the installed SMK release.
2. MelonLoader and SMK installed into that game copy.
3. .NET 6 SDK and a configured `GamePath` for the project.
4. A clean test save and a documented successful in-game load.

### Android

1. A lawful Android test environment and an official game build owned by the tester.
2. A compatible, trusted Android IL2CPP modding/injection approach that does not rely on a repackaged third-party APK.
3. An Android device or emulator for repeatable testing.
4. A separate Android compatibility and packaging design, verified against the target game version.

Until its gates are met, Android remains planned rather than supported. No platform is called supported until it passes a real in-game test.
