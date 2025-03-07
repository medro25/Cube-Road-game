using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public GameObject GameOverUI;
    
    

    public void Startgame()
    {
        Debug.Log("🎮 StartGame() function called!");
        string currentScene = SceneManager.GetActiveScene().name;

        // 🔥 Check if GameOverUI is assigned before using it
        if (GameOverUI == null) 
        {
            GameOverUI = GameObject.Find("Gameover"); // 🔥 Finds it by name in the scene
            if (GameOverUI == null)
            {
                Debug.LogError("❌ GameOverUI is STILL NOT found in the scene!");
            }
            else
            {
                Debug.Log("✅ GameOverUI found and assigned automatically.");
            }
        }

        // ✅ If the Game Over UI is active, reload the scene
        if (GameOverUI != null && GameOverUI.activeSelf)
        {
            Debug.Log("🛑 Game Over UI detected. Restarting the scene...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
          

            return; // ✅ Prevents further execution
        }

        // ✅ If on Welcome Screen, start from Level 1
        if (currentScene == "Welcomescreen")
        {
            Debug.Log("🚀 Starting the game from Level 1...");
            SceneManager.LoadScene("Level1");
            

        }
        else
        {
            Debug.Log("⏭ Loading the next scene...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
     // ✅ Coroutine to delay scene loading
   
}

