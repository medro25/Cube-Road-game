using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
     public TMP_Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text=player.position.z.ToString("0");
    }
}
