using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceScript : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate() {
		rb.AddForce(transform.forward * speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
