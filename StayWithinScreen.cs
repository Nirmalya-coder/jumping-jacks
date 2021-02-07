using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayWithinScreen : MonoBehaviour {

	public Camera MainCamera;
	private Vector2 screenBounds;
	private float objectWidth;
	public float adj;

	// Use this for initialization
	void Start () {
		screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
		objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x; //extents = size of width / 2
	}

	// Update is called once per frame
	void LateUpdate(){
		Vector3 viewPos = transform.position;

		if (viewPos.x > screenBounds.x + objectWidth + adj)
			viewPos = new Vector2(-screenBounds.x - objectWidth - adj, viewPos.y);
		if (viewPos.x < -screenBounds.x - objectWidth - adj)
			viewPos = new Vector2(screenBounds.x + objectWidth + adj, viewPos.y);
		transform.position = viewPos;
	}
}
		
	
