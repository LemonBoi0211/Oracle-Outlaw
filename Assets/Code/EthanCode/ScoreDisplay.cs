using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score;
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
    }

}
