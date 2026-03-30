![Unity](https://img.shields.io/badge/Engine-Unity-black)
![C#](https://img.shields.io/badge/Language-C%23-blue)

# 🏓 Pong (Unity)

A simple **Pong clone built in Unity**, developed as part of the [20 Games Challenge](https://github.com/LeoAndriolo/20GamesChallenge).

This project focuses on core gameplay systems, clean architecture, and basic game feel improvements such as sound effects and UI flow.

Play it here: [Pong](https://leoandriolo.itch.io/pong-20gameschallenge)

---

## 🎮 Features

- Classic Pong gameplay  
- Two paddles (Player vs AI)  
- Ball physics with dynamic bounce  
- Score system with win condition  
- Start / Reset game flow  
- Game state management (Menu, Playing, Game Over)  
- UI with result screen (Victory / Defeat)  
- Sound effects:
  - Paddle hit (with dynamic pitch)
  - Goal
  - Win / Lose feedback  
- Basic AI opponent  

---

## 🧠 What I Learned

- Unity **2D physics and collisions**  
- Unity **New Input System**  
- Game architecture with a **GameManager**  
- Handling **game states**  
- Implementing **UI with TextMeshPro**  
- Adding **game feel (SFX, feedback, flow)**  
- Creating simple **AI behavior**  

---

## ⚠️ Challenges & Lessons Learned

- Building too many systems at once made debugging difficult — breaking the work into smaller steps made issues easier to identify and fix
- Early playtesting revealed misconfigured Layers, which affected collisions and overall game behavior
- Reusing objects without checking transforms led to unintended rotation (-90°) on paddles
- This rotation caused incorrect movement (horizontal instead of vertical), highlighting the importance of validating object orientation and local axes
- Small setup mistakes in Unity (Transforms, Layers, Colliders) can have a big impact on gameplay, reinforcing the need for early and frequent testing 

---

## 🛠️ Tech Stack

- Unity (2D)  
- C#  
- Unity Input System  
- TextMeshPro  

---

## ▶️ How to Play

- **Left Paddle (Player)**  
  - Move Up: `W`  
  - Move Down: `S`  

- **Right Paddle**  
  - Controlled by AI  

---

## 🚀 Getting Started

1. Clone the repository:

    git clone https://github.com/LeoAndriolo/20GamesChallenge.git

2. Open the project in Unity Hub  

3. Navigate to the Pong project folder:

    Games/01_Pong

4. Open the main scene:

    Assets/Scenes/MainScene

5. Press ▶️ Play  

---

## 📂 Project Structure
 
```text
Games/
└── 01_Pong/
    └── Assets/
        ├── Art/
        ├── Audio/
        ├── Fonts/
        ├── Input/
        ├── Materials/
        ├── Prefabs/
        ├── Scenes/
        └── Scripts/
```

---

## 🔥 Future Improvements

- Add difficulty UI selection for AI  
- Add visual effects (particles, trails)  
- Add main menu with game mode selection (2 players or vs IA)
- Improve UI animations  
- Add local multiplayer (2 players)  

---

## 📝 Changelog

### Version 1.01 - 2026-03-30

**🐞 Bug Fixes**
- Fixed paddle corner collision inconsistencies  
- Resolved double kick issue on paddle collision  
- Fixed bug where the ball could escape through the wall after the first goal  
- Improved consistency of ball behavior when bouncing on walls  

**✨ New Features**
- Added paddle image to the start screen  
- Added wall hit sound effects  
- Updated font to Press Start 2P  

---

## 📄 License

This project is open-source and available under the MIT License.
