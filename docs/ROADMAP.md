# Roadmap

## 0. Technical reconnaissance

- [ ] Confirm the target Suzerain version.
- [ ] Identify the game's story/content file formats.
- [ ] Identify how text, decisions, events, Codex entries, and localization are loaded.
- [ ] Determine whether a loader/framework is required.
- [ ] Create a reproducible extraction, modification, packaging, and testing workflow.

## 1. First working modification

- [ ] Make one harmless, verifiable text change.
- [ ] Package it for the target game.
- [ ] Confirm the modified game loads successfully.
- [ ] Document the procedure in `docs/MODDING.md`.

## 2. Content framework

- [ ] Establish source identifiers for story text.
- [ ] Establish event/decision identifiers.
- [ ] Establish Codex identifiers.
- [ ] Establish localization keys.
- [ ] Add validation for duplicate or missing identifiers.

## 3. Story expansion

- [ ] Add first new decision.
- [ ] Add first new event chain.
- [ ] Add first additional turn.
- [ ] Connect new content to existing campaign state.
- [ ] Add consequences and continuity checks.

## 4. Codex expansion

- [ ] Define Codex schema.
- [ ] Add initial expanded entries.
- [ ] Link Codex entries to story content.
- [ ] Test Codex navigation and localization.

## 5. Fixes

- [ ] Establish a confirmed-bug registry.
- [ ] Implement and test the first fix.
- [ ] Add regression checks where possible.

## 6. Major-language localization

- [ ] Finalize source-language key structure.
- [ ] Add Spanish.
- [ ] Add Simplified Chinese.
- [ ] Add Hindi.
- [ ] Add Arabic.
- [ ] Add Portuguese.
- [ ] Add Russian.
- [ ] Add Japanese.
- [ ] Add German.
- [ ] Add French.
- [ ] Add Italian.
- [ ] Add Korean.

## 7. Release

- [ ] Full campaign test.
- [ ] Translation completeness check.
- [ ] Regression testing.
- [ ] Packaging and installation instructions.
- [ ] Versioned public release.
