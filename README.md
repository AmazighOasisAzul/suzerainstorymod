# Suzerain Story Mod

A community-developed story expansion for **Suzerain**.

The goal is to expand the political roleplaying experience without losing the writing, choices, consequences, and institutional focus that define the base game.

## Project goals

- Add additional turns and extend campaigns beyond the existing story.
- Add new decisions, dialogue, events, interactions, and text options.
- Expand the Codex with additional countries, institutions, political concepts, characters, events, and historical context.
- Fix bugs, inconsistencies, broken text, and other issues discovered during development.
- Expand localization beyond English, prioritizing major world languages with large player populations.
- Build the project in a maintainable structure so story content, Codex entries, fixes, and translations can be developed independently.

## Current status

**Early development.**

The repository is currently establishing the project's documentation, content structure, localization framework, and development workflow. Game-specific implementation will be added once the exact runtime/modding interface and supported game version are confirmed.

Nothing in this repository should be assumed to work in-game until it has been tested against the target Suzerain build.

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

### Bug fixes and corrections

The mod will maintain a dedicated record of confirmed issues and fixes. Corrections should be documented rather than silently changing behavior wherever practical.

### Localization

Localization will prioritize major global languages first. Initial planning targets include English, Spanish, Chinese (Simplified), Hindi, Arabic, Portuguese, Russian, Japanese, German, French, Italian, and Korean.

Language support will be added according to the actual technical capabilities of the game's text system and the availability of translators.

## Repository structure

```text
suzerainstorymod/
├── README.md
├── CONTRIBUTING.md
├── docs/
│   ├── DESIGN.md
│   ├── ROADMAP.md
│   ├── LOCALIZATION.md
│   └── MODDING.md
├── content/
│   ├── story/
│   ├── events/
│   ├── decisions/
│   ├── characters/
│   └── codex/
├── localization/
│   ├── en/
│   ├── es/
│   ├── zh-CN/
│   ├── hi/
│   ├── ar/
│   ├── pt-BR/
│   ├── ru/
│   ├── ja/
│   ├── de/
│   ├── fr/
│   ├── it/
│   └── ko/
├── fixes/
└── tools/
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
- [ ] Document confirmed game version and modding/runtime method
- [ ] Map relevant base-game files and data structures
- [ ] Establish a repeatable testing workflow

### Phase 2 — Content framework

- [ ] Implement the first additional turn
- [ ] Implement the first new decision/event chain
- [ ] Establish Codex entry format
- [ ] Establish localization source format
- [ ] Add automated validation where practical

### Phase 3 — Expansion

- [ ] Expand the additional-turn system
- [ ] Add substantial new story content
- [ ] Expand Codex coverage
- [ ] Implement the first major bug fixes
- [ ] Begin major-language translations

### Phase 4 — Testing and release

- [ ] Full campaign testing
- [ ] Localization testing
- [ ] Regression testing
- [ ] Compatibility documentation
- [ ] First public release

## Contributing

Contributions are welcome once the technical foundation is established. See [CONTRIBUTING.md](CONTRIBUTING.md) for the project workflow.

## Disclaimer

This is an unofficial community project and is not affiliated with or endorsed by the creators or publishers of Suzerain.

## License

A project license has not yet been selected. Until one is added, all rights to original material in this repository remain with their respective authors.
