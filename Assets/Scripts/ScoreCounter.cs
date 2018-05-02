using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class ScoreCounter : MonoBehaviour {
    public static int score;

    private Text scoreCounterText;

	
	void Start () {
        score = 0;
        scoreCounterText = GetComponent<Text>();
	}
	
	
	void Update () {
        scoreCounterText.text = score + " Flies";
	}
}
