using UnityEngine;
using System.Collections; 

public class CubeMove : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;   
    public float sidewayForce = 500f;
    public float delayBeforeGameOver = 2.0f;
    
    private bool hasFallen = false; // ✅ Prevents multiple coroutine calls

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < 1f && !hasFallen) // ✅ Only call once when the player falls
        {
            hasFallen = true; // ✅ Prevent multiple calls
            StartCoroutine(GameOverAfterDelay()); 
        }
    }

    IEnumerator GameOverAfterDelay()
    {
        AudioManager audioManager = FindObjectOfType<AudioManager>();

        if (audioManager != null)
        {
            Debug.Log("✅ AudioManager found, playing PlayerDeath sound.");
            audioManager.Stop("Theme");  
            audioManager.Play("PlayerDeath"); // ✅ Play sound immediately ONCE
        }
        else
        {
            Debug.LogWarning("⚠️ AudioManager not found!");
        }

        yield return new WaitForSeconds(delayBeforeGameOver); // ✅ Wait before showing Game Over UI

        FindObjectOfType<GameManager>().Endgame(); // ✅ Show Game Over UI after sound
    } 
}
