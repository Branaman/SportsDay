using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootBall : MonoBehaviour {
	public GameObject bullet;
	public Transform shootPoint;
	public string level;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKeyDown("space")) {
			Instantiate(bullet, shootPoint.position, gameObject.transform.rotation);
		}

		if( Input.GetKeyDown(KeyCode.Q)) {
			// quit Scene and return to world map...
			print("I want to leave game!");
            Application.Quit();

		}
	}
}
