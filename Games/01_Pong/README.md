![Unity](https://img.shields.io/badge/Engine-Unity-black)
![C#](https://img.shields.io/badge/Language-C%23-blue)

# 🏓 Pong (Unity)

A simple **Pong clone built in Unity**, developed as part of a game development learning journey.

This project focuses on core gameplay systems, clean architecture, and basic game feel improvements such as sound effects and UI flow.

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

- Pressing Play with too many systems implemented at once made debugging harder  
- Testing features incrementally made issues easier to isolate  
- First Play revealed incorrect Layer configuration on game objects  
- Paddles were rotated at -90 degrees because they were created from another object  
- This caused horizontal movement instead of vertical movement  

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

    git clone https://github.com/your-username/pong-unity.git

2. Open the project in Unity Hub  

3. Open the main scene:

    Assets/Scenes/MainScene

4. Press ▶️ Play  

---

## 📂 Project Structure

    Assets/
     ├── Scripts/
     │    └── Runtime/
     │         ├── GameManager.cs
     │         ├── Ball.cs
     │         ├── PaddleController.cs
     │         └── GameState.cs
     │
     ├── Scenes/
     └── Prefabs/

---

## 🔥 Future Improvements

- Add difficulty selection for AI  
- Add sound variations  
- Add visual effects (particles, trails)  
- Add main menu with game mode selection  
- Improve UI animations  
- Add local multiplayer (2 players)  

---

## 📄 License

This project is open-source and available under the MIT License.