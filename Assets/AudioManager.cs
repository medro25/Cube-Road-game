using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds; // 🎵 List of all sounds
    public static AudioManager instance; // 🎤 Singleton instance

    void Awake()
    {
        if (instance == null)
        {
            instance = this; // 🎤 Set the singleton instance
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Debug.LogWarning("⚠️ Duplicate AudioManager found, destroying new instance.");
            
            Destroy(gameObject); // 🗑 Destroy any other instances
            return;
        }
        
        DontDestroyOnLoad(gameObject); // 🚫🗑 Prevent AudioManager from being destroyed on scene change

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>(); // 🎙 Attach an AudioSource to each sound
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        // Check if the scene is NOT "Welcomescreen" before playing music
        if (currentScene != "Welcomescreen")
        {
            Play("Theme"); // Play background music for other scenes
        }
        else
        {
            Debug.Log("🚫 Stopping music for Welcomescreen scene.");
            Stop("Theme"); // Stop music if the scene is "Welcomescreen"
        }
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded; // 🔄 Listen for scene changes
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded; // 🛑 Stop listening when destroyed
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
{
     Debug.Log($"🆕 Scene Loaded: {scene.name} (Index: {scene.buildIndex})");

    if (scene.name == "UI"|| scene.name == "Welcomescreen") // If the final scene "UI" is loaded
    {
        Stop("Theme"); // Stop the background music
        Debug.Log("Final UI scene loaded, stopping music.");
    }
    else
    {
        Play("Theme"); // Keep playing music in other scenes
    }
}


    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found in AudioManager!");
            return;
        }

        s.source.Stop(); // 🛑 Stop the sound before playing (prevents overlapping issues)
        s.source.Play(); // ▶️ Play the sound
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found in AudioManager!");
            return;
        }
        Debug.Log("Stopping sound: " + name); // ✅ Log to confirm it's being called
        s.source.Stop();
       
    }
}
