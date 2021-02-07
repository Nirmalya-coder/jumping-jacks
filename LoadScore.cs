using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScore : MonoBehaviour {

	private int score;
	private int maxDistance;
	// Update is called once per frame
	void Update () {
		score = PlayerPrefs.GetInt ("coinScore");
		maxDistance = PlayerPrefs.GetInt ("maxScore");
	}
}
