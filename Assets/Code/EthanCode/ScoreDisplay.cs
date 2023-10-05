using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{

    public Text scoreText;
    public Text pointsText;

    int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        pointsText.text = scoreText.ToString() + " POINTS";
    }
}
