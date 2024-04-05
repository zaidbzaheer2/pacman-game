using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    [SerializeField] private Text highScoreText, scoreText;
    private int highScore;

    private void Start()
    {
        try
        {
            highScore = PlayerPrefs.GetInt("HighScore@pacman");
        } catch
        {

            highScore = 0;
        }
    }
    void Update()
    {
        scoreText.text = $"Score\n{GameManager.score}";
        highScoreText.text = $"High Score\n{highScore}";
       if (GameManager.score > highScore)
        {
            highScore = GameManager.score;
            //Debug.Log($"Scoring :{highScore}");
            PlayerPrefs.SetInt("HighScore@pacman", highScore);
            
        }
    }
}
