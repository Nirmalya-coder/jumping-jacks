using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTravelled : MonoBehaviour {

	private float startPos;
	private float newPos;
	public static int distance;

	// Use this for initialization
	void Start () {
		startPos = transform.position.x;
	}

    // Update is called once per frame
    void Update()
    {
        newPos = transform.position.x;
        distance = (int)(newPos - startPos);
    }
    public void increaseDist()
    { 
        distance = (int)(newPos - startPos) + 20;
       
    }

}

