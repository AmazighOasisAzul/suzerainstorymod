# Design Specification

## Core objective

Suzerain Story Mod is a content expansion project. The primary objective is to create substantially more political roleplay while preserving the game's decision-driven structure.

## Expansion model

The project is divided into four connected layers:

1. **Story** — turns, scenes, dialogue, and narrative progression.
2. **Gameplay choices** — decisions, conditions, variables, and consequences.
3. **Codex** — persistent reference material that expands alongside the world.
4. **Localization** — translations of the same stable source content.

## Additional turns

The additional-turn system should feel like a continuation of the campaign rather than an unrelated sequel. New turns should inherit relevant state from the player's existing decisions wherever the game's implementation permits it.

Each turn should define:

- Entry conditions
- Opening state
- Available scenes/events
- Decisions
- Character interactions
- Variable changes
- End conditions
- Codex updates
- Localization keys

## Decisions

A new decision should have a meaningful trade-off. Whenever practical, choices should produce delayed consequences rather than only immediate numerical changes.

## Events

Events should be modular and reusable where possible. Event identifiers must remain stable after publication so that translations and dependent content do not break.

## Codex

Codex entries should be linked to the content that introduces them. New entries should not reveal information that the player has no reasonable way to know unless the base game already treats the Codex as an omniscient reference.

## State and continuity

The project must preserve continuity between existing campaign decisions and new content. Important state should be documented rather than hidden inside individual event files.

## Compatibility

Until the game's current file format, executable/runtime, supported mod loader, and distribution method are verified, implementation details remain provisional. The repository should not lock itself into a fictional API or loader.
