# Obstacle Dodger

A small 3D Unity prototype in which the player moves through a course of stationary and moving hazards while trying to avoid collisions.

## Gameplay

Navigate the player around walls, spinning obstacles, delayed falling objects, and triggered projectiles. Colliding with an obstacle changes it to red, plays a hit sound, and records the collision count in the Unity Console. The project also includes background music and a menu scene.

### Controls

| Action | Keyboard |
| --- | --- |
| Move forward/backward | <kbd>W</kbd> / <kbd>S</kbd> or ↑ / ↓ |
| Move left/right | <kbd>A</kbd> / <kbd>D</kbd> or ← / → |

## Running the project

1. Clone or download this repository.
2. Add the project folder in Unity Hub.
3. Open it with **Unity 6 (6000.0.39f1)**.
4. Open `Assets/Scenes/Menu.unity` and enter Play mode. To skip the menu, open `Assets/Scenes/SampleScene.unity` directly.

The project uses the Universal Render Pipeline. Unity should restore the required packages from `Packages/manifest.json`.

## Project structure

- `Assets/Scenes/` — menu and gameplay scenes
- `Assets/Scripts/Mover.cs` — player movement
- `Assets/Scripts/Scorer.cs` and `ObjectHit.cs` — collision counting and feedback
- `Assets/Scripts/Dropper.cs`, `Spinner.cs`, `FlyAtPlayer.cs`, and `TriggerProjectile.cs` — hazard behaviours
- `Assets/Scripts/AudioManager.cs` — background music and hit sound playback
- `Assets/Prefabs/` — player, walls, falling/spinning objects, and projectile hazards

## Status

Prototype/work in progress. The repository contains Unity source but no packaged executable.

Known menu issue: the current **Quit** button is wired to `PlayGame`, so it starts the gameplay scene instead of closing the application.

## Third-party content

The repository includes Unity TextMesh Pro resources and examples, plus bundled audio under `Assets/Sound/` (including folders named `8Bit Music - 062022` and `Casual Game Sounds U6`). Retain the included attribution and font-license files, and verify the relevant asset terms before redistribution. No repository-level license is currently included.
