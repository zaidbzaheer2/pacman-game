using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    private Text highScoreText, scoreText;
    public static int highScore;

    void InitializeScores()
    {
        highScoreText = GameObject.FindGameObjectWithTag("Stats").transform.GetChild(0).GetComponent<Text>();
        scoreText = GameObject.FindGameObjectWithTag("Stats").transform.GetChild(1).GetComponent<Text>();
    }    
    private void Start()
    {
        InitializeScores();
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
        if (scoreText != null)
            scoreText.text = $"Score\n{GameManager.score}";
        else
            InitializeScores();
        if(highScoreText!=null)
        highScoreText.text = $"High Score\n{highScore}";
       if (GameManager.score > highScore)
        {
            highScore = GameManager.score;
            //Debug.Log($"Scoring :{highScore}");
            PlayerPrefs.SetInt("HighScore@pacman", highScore);
            
        }
    }
}
