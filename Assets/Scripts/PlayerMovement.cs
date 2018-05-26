using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 3.0f;  // This variable is the default move speed (unity units per update, but when multiplied by deltatime it is roughly units per second)
	public float turnSpeed = 90.0f; // This variable is the default turn rate (degrees per update, but when multiplied by deltatime it is roughly degrees per second) Commented out due to inconsistent instructions

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame 
	void Update () 
	{
		// This code should move a single unit when shift + directional arrow is pressed
		// Note: Shift may be held
		if (Input.GetKey (KeyCode.LeftShift)) 				// if shift is held, don't do else statement below
		{
			if (Input.GetKeyDown (KeyCode.UpArrow)) 		// if up arrow is pressed while shift is held
			{
				transform.Translate (0, 1, 0); 				// go up 1 on the y axis
			}
			else if (Input.GetKeyDown (KeyCode.DownArrow))  // if down arrow is pressed while shift is held
			{
				transform.Translate (0, -1, 0); 			// go down 1 on the y axis
			}
			else if (Input.GetKeyDown (KeyCode.RightArrow)) // if right arrow is pressed while shift is held
			{
				transform.Translate (1, 0, 0); 				// go right 1 on the x axis
			}
			else if (Input.GetKeyDown (KeyCode.LeftArrow))  // if left arrow is pressed while shift is held
			{
				transform.Translate (-1, 0, 0); 			// go left 1 on the x axis
			}
		} 
		// This code moves the character when shift isn't pressed
		else 
		{
			// time.deltatime makes the character move on a per second basis instead of per update (roughly 60 times per second)
			// Mathematically movespeed is how fast the character will move, this is determined by a public variable
			// GetAxis returns -1, 1 or 0 (actually anywhere in between, but we enabled snap, high grav and sensitivity to make it a near instant transition)
			// If get axis is 0 nothing happens because when everything is multiplied with 0 it becomes 0, so no movement happens.
			transform.Translate (0, Time.deltaTime * moveSpeed * Input.GetAxis ("Vertical"), 0);
			transform.Translate (Time.deltaTime * moveSpeed * Input.GetAxis("Horizontal"), 0, 0);

			// This code rotates the character. We commented it out for now, because we don't want this script for the assignment, but it was good for testing local scale and want to use as an example later.
			//transform.Rotate (0, 0, 1 * Time.deltaTime * turnSpeed * Input.GetAxis("Horizontal") * -1);
		}
	}
}
