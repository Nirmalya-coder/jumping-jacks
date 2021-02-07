using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class print : MonoBehaviour {

	private GameObject[] Objects;

	// Use this for initialization
	void Start () {
		Objects = GameObject.FindGameObjectsWithTag ("music");
		if (Objects.Length > 1)
			Destroy (Objects[1]);
	}

}
