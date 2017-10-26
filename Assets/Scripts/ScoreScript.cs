using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

	public static int score;
	Text text; 

	void Awake () {
		text = GetComponent<Text>();
		score = 0;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Your Score:" + score;
	}
}
