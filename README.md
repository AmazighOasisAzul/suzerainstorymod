# Suzerain Story Mod

A story-expansion mod for **Suzerain**, created by **AmazighOasisAzul with AI-assisted development**.

The goal is to expand the political roleplaying experience without losing the writing, choices, consequences, and institutional focus that define the base game.

## Project goals

- Add additional turns and extend campaigns beyond the existing story.
- Add new decisions, dialogue, events, interactions, and text options.
- **Dream goal:** create an interactive text-response system where players can type their own responses instead of being limited to predefined choices, with the game interpreting the player's response and answering through its collected game/world information while preserving the game's political context and state.
- Expand the Codex with additional countries, institutions, political concepts, characters, events, and historical context.
- Use the **Suzerain updated world map** concept as the project's intended world-map reference: [Reddit world map reference](https://www.reddit.com/r/suzerain/comments/1tgzvwu/world_map_suzerain_updated_version/#lightbox).
- Fix bugs, inconsistencies, broken text, and other issues discovered during development.
- Expand localization beyond English, prioritizing only the world's major languages rather than small-language localization.
- Build the project in a maintainable structure so story content, Codex entries, fixes, and translations can be developed independently.

## Current status

**Early development — SMK scaffold added; not yet tested in-game.**

The repository is establishing the project's documentation, content structure, localization framework, and development workflow. Game-specific implementation will be added as the game's actual files, runtime, and modding interface are mapped and tested.

Nothing in this repository should be assumed to work in-game until it has been tested against the target Suzerain build.

## Platform scope

The mod targets **Windows (Steam PC)** and **Android** only. Linux and macOS are out of scope. These are separate technical targets: the existing C# MelonLoader project is Windows-only, while Android requires a distinct Unity IL2CPP integration. See [platform scope](docs/PLATFORMS.md) for the compatibility gates and current status.

## Planned content

### Story expansion

- New turns after the existing campaign.
- Additional presidential decisions and policy choices.
- New events and event chains.
- Additional character interactions.
- Expanded political, economic, diplomatic, military, and social choices.
- New consequences based on previous player decisions.
- Additional country and faction interactions where supported by the game's systems.

### Codex expansion

The Codex will be expanded alongside the story rather than treated as an afterthought.

Planned categories include:

- Countries and regions
- Political parties and movements
- Government institutions
- Political ideologies
- Economic concepts
- Military institutions
- Historical events
- Characters
- Organizations and factions
- Laws and constitutional concepts
- International relations
- World-map and geopolitical information

### World map

The project intends to use the updated Suzerain world-map concept referenced here as a visual and geographical foundation:

https://www.reddit.com/r/suzerain/comments/1tgzvwu/world_map_suzerain_updated_version/#lightbox

The exact technical implementation will depend on how the game handles its existing map assets and UI.

### Bug fixes and corrections

The mod will maintain a dedicated record of confirmed issues and fixes. Corrections should be documented rather than silently changing behavior wherever practical.

### Localization

Localization is deliberately limited to **major world languages**. The initial priority is based on the writing system and global importance of the language, not an attempt to support every language.

#### Immediate Latin-script translations

The first Latin-script translation targets are:

1. **European Spanish**
2. **French**
3. **Esperanto**

#### Major non-Latin-script languages

After the immediate Latin-script targets, localization will expand to major languages using other writing systems, including:

- **Mandarin Chinese (Simplified)**
- **Arabic**
- **Russian**
- **Hindi**
- **Japanese**
- **Korean**

Additional major world languages may be added if they meet the project's scope, but the project is not intended to become a comprehensive small-language localization project.

## Repository structure

```text
suzerainstorymod/
├── README.md
├── CONTRIBUTING.md
├── docs/
│   ├── DESIGN.md
│   ├── ROADMAP.md
│   ├── LOCALIZATION.md
│   ├── MODDING.md
│   └── PLATFORMS.md
├── content/
│   ├── story/
│   ├── events/
│   ├── decisions/
│   ├── characters/
│   └── codex/
├── src/
│   └── SuzerainStoryMod/       # C# MelonLoader + SMK project
├── localization/
│   ├── en/
│   ├── es-ES/
│   ├── fr/
│   ├── eo/
│   ├── zh-CN/
│   ├── ar/
│   ├── ru/
│   ├── hi/
│   ├── ja/
│   └── ko/
├── fixes/
└── tools/                      # Local validation scripts
```

This structure is intentionally content-first. Once the game's actual modding format is verified, implementation-specific directories can be introduced without restructuring the entire project.

## Development principles

1. **Do not invent unsupported APIs or game behavior.** Verify the target game's files and runtime before implementing engine-specific functionality.
2. **Keep content modular.** Story, Codex, localization, and fixes should be separable wherever the game allows it.
3. **Preserve player choice.** New content should create meaningful decisions rather than replacing the game's political roleplaying with linear exposition.
4. **Track dependencies.** New events and decisions should document the conditions and previous choices that affect them.
5. **Separate source text from translations.** English/source content should remain identifiable so translators can work against a stable source.
6. **Test before calling something fixed.** A documented fix should identify the original problem and the build in which it was verified.

## Development workflow

1. Document the feature or bug.
2. Determine how the base game implements the relevant system.
3. Create or modify the smallest necessary content/data set.
4. Test in the target game build.
5. Record compatibility notes and known limitations.
6. Commit the change with a descriptive message.

## Roadmap

### Phase 1 — Foundation

- [x] Create repository
- [x] Establish project README
- [ ] Identify the exact target Suzerain version
- [ ] Map the game's story files and data structures
- [ ] Determine the mod loading/patching method
- [ ] Establish a repeatable testing workflow

### Phase 2 — First working modification

- [ ] Extract and inspect an existing story event
- [ ] Reproduce one existing event in the project's working format
- [ ] Modify one existing text/choice as a controlled test
- [ ] Verify the modified content in-game
- [ ] Document the working mod installation method

### Phase 3 — Story framework

- [ ] Implement the first additional turn
- [ ] Implement the first new decision/event chain
- [ ] Establish Codex entry format
- [ ] Establish localization source format
- [ ] Add automated validation where practical

### Phase 4 — Expansion

- [ ] Expand the additional-turn system
- [ ] Add substantial new story content
- [ ] Expand Codex coverage
- [ ] Implement major bug fixes
- [ ] Begin the priority localization sequence
- [ ] Research feasibility of player-written responses

### Phase 5 — Testing and release

- [ ] Full campaign testing
- [ ] Localization testing
- [ ] Regression testing
- [ ] Compatibility documentation
- [ ] First public release

## Contributing

Contributions are welcome once the technical foundation is established. See [CONTRIBUTING.md](CONTRIBUTING.md) for the project workflow.

## Disclaimer

This is an unofficial independent mod and is not affiliated with or endorsed by the creators or publishers of Suzerain.

## License

A project license has not yet been selected. Until one is added, all rights to original material in this repository remain with their respective authors.
