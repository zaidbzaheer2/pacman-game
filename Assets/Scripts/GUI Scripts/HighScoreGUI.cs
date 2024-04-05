using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreGUI : MonoBehaviour
{
    private int highScore;
    private Text highScoreText;
    // Start is called before the first frame update
    
    void Start()
    {
        highScoreText = GetComponent<Text>();
        try
        {
            highScore = PlayerPrefs.GetInt("HighScore@pacman");
        }
        catch
        {
            highScore = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        highScoreText.text = $"High Score: {highScore}";
    }
}
