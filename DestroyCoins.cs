using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoins : MonoBehaviour {

	private float playerPos;

	void Update () {
		playerPos = GameObject.FindGameObjectWithTag ("Player").transform.position.x;
		if (Physics2D.OverlapCircle (new Vector2(transform.position.x, transform.position.y), 3f).CompareTag("Obstacle") || transform.position.x < playerPos - 20f)
			Destroy (gameObject);
		
			
	}
}
