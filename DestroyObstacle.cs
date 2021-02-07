using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour {

	private float playerPos;

	// Use this for initialization
	void Start () {
		playerPos = GameObject.FindGameObjectWithTag ("Player").transform.position.x;

	}
	
	// Update is called once per frame
	void LateUpdate () {
		playerPos = GameObject.FindGameObjectWithTag ("Player").transform.position.x;
		if (transform.position.x < playerPos - 20f)
		{
			Destroy (gameObject);
		}
	}
}
