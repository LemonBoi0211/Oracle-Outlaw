using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score;
    public int hiScore;
    private float timer;

    void Start()
    {
        scoreText.text = "Score: ";
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 1f)
        {
            score += 1;

            scoreText.text = "Score: " + score;

            timer = 0;
        }

        if(score > hiScore)
        {
            hiScore = score;
        }

        int originalHiScore = PlayerPrefs.GetInt("High Score", 0);
        if(hiScore > originalHiScore)
        {
            PlayerPrefs.SetInt("High Score", hiScore);
        }

        PlayerPrefs.SetInt("Current Score", score);
    }

}
