using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{

    public Text scoreText;
    public Text pointsText;

    int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        pointsText.text = score.ToString() + " POINTS";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
