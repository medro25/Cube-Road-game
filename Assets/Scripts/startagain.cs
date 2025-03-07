using UnityEngine;
using UnityEngine.SceneManagement;
public class startagain : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartScene()
    {
        // Get the currently active scene and reload it
        Debug.Log("Game over cliked");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
