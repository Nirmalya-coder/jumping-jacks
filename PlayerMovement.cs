using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float runspeed = 60f;
	public bool jump = false;
	public float val = 60f;
	public CharacterController2D controller;
	public Animator animator;
	private int distance;

   
    // Update is called once per frame
    void Update (){

		distance = DistanceTravelled.distance;
		if (distance < 200)
			runspeed = val;
		if (distance > 200)
			runspeed = val * 1.3f;
		if (distance > 400)
			runspeed = val * 1.5f;
		if (distance > 600)
			runspeed = val * 1.7f;
		if (distance > 900)
			runspeed = val * 1.9f;
		if (distance > 1300)
			runspeed = val * 2.1f;
		if (distance > 1500)
			runspeed = val * 2.2f;
		if (distance > 1900)
			runspeed = val * 2.3f;

        animator.SetBool("isJumping", !controller.m_Grounded);
	
	}

	private void Awake()
	{
		SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
	}
	private void SwipeDetector_OnSwipe(SwipeData data)
	{
		
		if (data.Direction == SwipeDirection.Up && jump == false && Time.timeScale == 1f)
		{
			FindObjectOfType<AudioManager>().Play ("PlayerJump");
			jump = true;
		}
	}
		
	void FixedUpdate()
	{
		
		controller.Move (runspeed * Time.fixedDeltaTime, false, jump);
		jump = false;
	}
}
