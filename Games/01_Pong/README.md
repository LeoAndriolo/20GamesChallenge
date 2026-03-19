![Unity](https://img.shields.io/badge/Engine-Unity-black)
![C#](https://img.shields.io/badge/Language-C%23-blue)

# 🏓 Pong (Unity)

A simple **Pong clone built in Unity**, developed as part of the  
[20 Games Challenge](https://github.com/LeoAndriolo/20GamesChallenge).

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

    Games/
     └── 01_Pong/
          └── Assets/
               ├── Audio/
               ├── Input/
               ├── Materials/
               ├── Scenes/
               └── Scripts/

---

## 🔥 Future Improvements

- Add difficulty UI selection for AI  
- Add sound variations  
- Add visual effects (particles, trails)  
- Add main menu with game mode selection (2 players or vs IA)
- Improve UI animations  
- Add local multiplayer (2 players)  

---

## 📄 License

This project is open-source and available under the MIT License.