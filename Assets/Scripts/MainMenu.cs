using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Method to load the Welcome Screen (Main Menu)
    public void GoToWelcomeScreen()
    {
        Debug.Log("CLICKED");
        SceneManager.LoadScene(0); // Replace with your actual scene name
    }
}