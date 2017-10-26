using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour {

	public GameObject star;
	public int points;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Handle a star hitting the sphere...
	void OnTriggerEnter(Collider other)
	{
		// If the entering collider is the player...
//		if (other.gameObject == star)
		if (other.tag == "Star")
		{
			ScoreScript.score += points;
		}
	}
}
