## 📝 Project Description
Fruit Catcher is a complete 2D arcade game built from scratch using Unity 6 (LTS). The objective is to move a basket left and right to catch falling fruits while avoiding falling bombs.

## 🎮 How to Play
*   **Move Left:** Left Arrow (←) or 'A'
*   **Move Right:** Right Arrow (→) or 'D'
*   **Catch a Fruit:** +1 Point
*   **Catch a Bomb:** -1 Life
*   **Miss a Fruit:** -1 Life
*   **Goal:** Get the highest score possible before losing all 3 lives!

## ✨ Features Implemented
*   **Player Movement:** Smooth horizontal movement with screen boundaries (using `Mathf.Clamp`).
*   **Physics & Collisions:** Utilizes Rigidbody 2D and Trigger Colliders to detect catches.
*   **Prefabs & Spawning:** A dynamic spawner system that drops fruits and bombs at random X positions and intervals.
*   **UI & Scoring:** Real-time Score and Lives tracking using TextMeshPro.
*   **Start Menu:** An instructions panel that pauses the game (`Time.timeScale = 0`) until the player clicks "Play".
*   **Game Over & Restart:** A functional Game Over screen that freezes the game and allows the player to restart.

## 🛠️ How to Open the Project
1. Ensure you have **Unity 6 (6000.0 LTS)** installed via Unity Hub.
2. Clone this repository to your local machine.
3. Open Unity Hub, click **Add**, and select the folder you just cloned.
4. In the Project window, navigate to `Assets > Scenes` and double-click **SampleScene**.
5. Press the **Play** button at the top of the editor.

*Note: The `Library` folder is excluded from this repository to save space, as Unity will automatically regenerate it when the project is opened for the first time.*

## 📂 Project Structure
*   `Assets/`: Contains all scripts, sprites, scenes, and prefabs.
*   `Packages/`: Contains Unity package dependencies.
*   `ProjectSettings/`: Contains all project configuration settings (input, physics, etc.).
