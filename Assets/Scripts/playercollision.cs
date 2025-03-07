using UnityEngine;
using System.Collections;  // Needed for coroutines

public class PlayerCollision : MonoBehaviour
{
    private AudioManager audioManager;
    public CubeMove movement;  // Reference to the movement script
    public float delayBeforeGameOver = 1.0f;  // Delay in seconds
    

    void Start()
{
    audioManager = FindObjectOfType<AudioManager>(); // ✅ Find AudioManager at the start
    if (audioManager == null)
    {
        Debug.LogError("❌ AudioManager NOT found in PlayerCollision!");
    }
    else
    {
        Debug.Log("✅ AudioManager found in PlayerCollision.");
    }
}


    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("Collision Detected with: " + collisionInfo.collider.name);

        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Obstacle Hit");
            movement.enabled = false;
            StartCoroutine(GameOverAfterDelay());
        }

       
    }

    // Coroutine to delay the game over call
    IEnumerator GameOverAfterDelay()
{
    if (audioManager != null)
    { Debug.Log("Stopping Theme Sound"); // ✅ Debug check
        audioManager.Stop("Theme");  
        Debug.Log("Theme Sound has been stopped"); // ✅ Debug check
        yield return new WaitForSeconds(0.1f); // ⏳ Short delay to allow stop before playing new sound
        audioManager.Play("PlayerDeath");
         Debug.Log("PlayerDeath has been played");
    }
    else
    {
        Debug.LogWarning("AmineAudioManager not found!");
    }

    yield return new WaitForSeconds(delayBeforeGameOver); // ⏳ Now wait before showing the UI

    FindObjectOfType<GameManager>().Endgame(); // ✅ UI appears AFTER the sound starts
}

}
