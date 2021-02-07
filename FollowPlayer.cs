
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform Player;
	public float offset = 0.125f;

	void Start()
	{
		transform.position = new Vector3(transform.position.x, Player.position.y + offset, transform.position.z);

	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Player.position.x + offset, Player.position.y + offset, transform.position.z);
		
	}
}
