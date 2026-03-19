![Unity](https://img.shields.io/badge/Engine-Unity-black)
![C#](https://img.shields.io/badge/Language-C%23-blue)

🏓 Pong (Unity)

A simple Pong clone built in Unity, developed as part of a game development learning journey.

This project focuses on core gameplay systems, clean architecture, and basic game feel improvements such as sound effects and UI flow.

🎮 Features

Classic Pong gameplay

Two paddles (Player vs AI)

Ball physics with dynamic bounce

Score system with win condition

Start / Reset game flow

Game state management (Menu, Playing, Game Over)

UI with result screen (Victory / Defeat)

Sound effects:

Paddle hit (with dynamic pitch)

Goal

Win / Lose feedback

Basic AI opponent

🧠 What I Learned

Unity 2D physics and collisions

Unity New Input System

Game architecture with a GameManager

Handling game states

Implementing UI with TextMeshPro

Adding game feel (SFX, feedback, flow)

Creating simple AI behavior

Writing basic unit tests (Unity Test Framework)

Setting up CI pipeline (GitHub Actions)

🛠️ Tech Stack

Unity (2D)

C#

Unity Input System

TextMeshPro

Unity Test Framework

▶️ How to Play

Left Paddle (Player)

Move Up: W

Move Down: S

Right Paddle

Controlled by AI

🚀 Getting Started

Clone the repository:

git clone https://github.com/your-username/pong-unity.git

Open the project in Unity Hub

Open the main scene:

Assets/Scenes/MainScene

Press ▶️ Play

🧪 Running Tests

Open:

Window → General → Test Runner

Run Edit Mode tests

📂 Project Structure
Assets/
 ├── Scripts/
 │    └── Runtime/
 │         ├── GameManager.cs
 │         ├── Ball.cs
 │         ├── PaddleController.cs
 │         └── GameState.cs
 │
 ├── Tests/
 │    └── EditMode/
 │         └── GameManagerTests.cs
 │
 ├── Scenes/
 └── Prefabs/
🔥 Future Improvements

Add difficulty selection for AI

Add sound variations

Add visual effects (particles, trails)

Add main menu with game mode selection

Improve UI animations

Add local multiplayer (2 players)

📺 Devlog

This project is part of a game dev learning series.

📄 License

This project is open-source and available under the MIT License.
