using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObstacle : MonoBehaviour {

	public float wait = 3f;
	public Transform Player;
	public GameObject[] Obstacles = new GameObject[5];
	int random;

	// Use this for initialization
	void Start()
	{
		StartCoroutine (SpawnObstacle (wait));
	}

	IEnumerator SpawnObstacle(float delay)
	{
		while (true) {
			yield return new WaitForSeconds (delay);
			spawn ();
		}
	}

	void spawn()
	{
		random = Random.Range (0, 5);
		GameObject a = Instantiate (Obstacles [random]) as GameObject;
		a.transform.position = new Vector2 (Player.position.x + Random.Range (15f, 30f), -4.8f);

	}
}



