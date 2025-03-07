# Cube Road Game

## 🎮 About the Game
**Cube Road** is an endless runner-style game developed in **Unity 2022.3.4f1**. The player controls a moving cube, avoiding obstacles and progressing through levels. The game includes audio management, UI interactions, level progression, and a scoring system.

## 🚀 Features
- **Player Movement**: Control the cube with arrow keys.
- **Obstacles**: Randomly positioned obstacles to avoid.
- **Game Manager**: Handles level transitions and game over logic.
- **Score System**: Tracks and displays score based on distance.
- **Audio Manager**: Plays background music and sound effects.
- **Camera Follow**: Smoothly follows the player.
- **UI Elements**: Includes a main menu, game over screen, and level complete UI.

## 🛠 Technologies Used
- **Unity Engine (2022.3.4f1)**
- **C# Scripting**
- **Unity Scene Management**
- **Unity Audio System**
- **Physics-based Rigidbody Controls**

## 📂 Project Structure
```plaintext
Cube Road Game/
│── Assets/
│   ├── Scripts/            # C# Scripts for game mechanics
│   ├── Audio/              # Sound effects and background music
│   ├── Prefabs/            # Reusable game objects
│   ├── Scenes/             # Game levels
│   ├── UI/                 # UI elements (buttons, menus)
│   └── Materials/          # Textures and materials
│── Packages/
│── ProjectSettings/
│── README.md               # Project documentation
```

## 📜 Scripts Overview

### 🔹 Player Movement (`CubeMove.cs`)
- Moves the cube forward.
- Allows side movement using arrow keys.
- Detects falling off the platform and triggers game over.

### 🔹 Collision Detection (`PlayerCollision.cs`)
- Stops movement when colliding with obstacles.
- Plays a death sound effect.
- Calls the **Game Manager** to handle game over.

### 🔹 Game Manager (`GameManager.cs`)
- Manages game over state.
- Loads next levels.
- Handles UI interactions.

### 🔹 Audio Manager (`AudioManager.cs`)
- Manages game music and sound effects.
- Stops/plays music based on game state.

### 🔹 Camera Follow (`followcamera.cs`)
- Ensures the camera follows the cube smoothly.

### 🔹 UI Scripts (`Menu.cs`, `MainMenu.cs`, `LevelCompleted.cs`)
- Handles menu navigation.
- Manages scene transitions.

## 🎵 Sound System
- Uses `AudioManager.cs` to handle background music and effects.
- Stops theme music upon game over or level completion.
- Plays `PlayerDeath` sound on collision.

## 🎯 How to Play
1. **Run the game in Unity.**
2. Use **Right Arrow (→)** to move right.
3. Use **Left Arrow (←)** to move left.
4. Avoid obstacles to keep running.
5. Reach the **end goal** to progress.

## 🛠 Setup Instructions

### **Clone the Repository**
```sh
git clone https://github.com/medro25/Cube-Road-game.git
```
### **Open in Unity**
1. Open **Unity Hub**.
2. Click **Open** and select the cloned project folder.
3. Load **Level1.scene** to start.

### **Build the Game**
1. Go to **File > Build Settings**.
2. Select your **target platform** (Windows, macOS, WebGL, etc.).
3. Click **Build and Run**.

## 📌 Future Improvements
- Add power-ups (speed boost, invincibility, etc.).
- Improve obstacle generation.
- Implement multiplayer support.
- Add more levels and themes.
- change the colour while swtiching between the levels

  ## Screenshots
  
<img width="300" alt="image" src="https://github.com/user-attachments/assets/0fa3557f-0525-4ef1-9efc-913579608a76" />

  <img width="300" alt="image" src="https://github.com/user-attachments/assets/e19e2a83-0a6a-4bd7-a0fd-06a59ea6b26b" />
  <img width="300" alt="image" src="https://github.com/user-attachments/assets/81a0e68f-c706-4302-84d2-e67e8637899a" />
<img width="300" alt="image" src="https://github.com/user-attachments/assets/c7b7eaed-7ae6-4a67-9b07-96997aa127b3" />
<img width="300" alt="image" src="https://github.com/user-attachments/assets/d134d29d-bec7-4feb-b8f3-72de714339cc" />
<img width="300" alt="image" src="https://github.com/user-attachments/assets/6b1b81da-2275-4312-81f7-ac24371d0015" />







