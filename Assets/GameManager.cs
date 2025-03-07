using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections; 

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    bool gameHasEnded = false;
    public float restartdelay=2f;
    public float sceneLoadDelay = 10f; // Delay before loading new scenes
    public GameObject CompleteLevelUI ;
    public GameObject GameOverUI;
     bool levelCompleted = false;
       public bool IsGameOver { get; private set; } = false;
    public void LevelCompleted()
    {
        if (!levelCompleted)  // Check if the level is already completed
        {
            levelCompleted = true;
            CompleteLevelUI.SetActive(true);

            // Stop the theme music when the level is completed
            if (AudioManager.instance != null)
            {
                AudioManager.instance.Stop("Theme");
                
                Debug.Log("🎵 Theme music stopped as level is completed!");
               
            }
             // 🔥 Add delay before moving to next scene
            StartCoroutine(LoadSceneWithDelay(SceneManager.GetActiveScene().buildIndex + 1, "Level Completed"));

        }
    }


    public void Endgame()
    {
        if(gameHasEnded==false)
        {
       
            //gameHasEnded = true;
            //IsGameOver = true; // 🔥 NEW CHANGE: Mark game as over
            Debug.Log("Game Over triggered!"); // 🔥 NEW CHANGE: Debug check
            GameOverUI.SetActive(true);
            
            AudioManager.instance.Stop("Theme");
            Debug.Log("Theme music stopped as game is over!");
            
            
             //Invoke("restart",restartdelay);
        }
    }

    public void restart()
    {

        IsGameOver = false; 
        gameHasEnded = false; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
       
    }

    // ✅ Coroutine to delay scene loading
    IEnumerator LoadSceneWithDelay(int sceneIndex, string reason)
    {
        Debug.Log($"⏳ [{reason}] Waiting {sceneLoadDelay} seconds before loading scene {sceneIndex}...");
        yield return new WaitForSeconds(sceneLoadDelay); // ⏳ Wait before loading
        Debug.Log($"🚀 [{reason}] Time's up! Loading new scene {sceneIndex} now.");
        SceneManager.LoadScene(sceneIndex);
    }
}
