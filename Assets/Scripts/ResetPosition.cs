using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour {

	public Vector3 defaultPosition = new Vector3 (0,0,0); // Store world origin location as default position. If we want player to start elsewhere, we can store that here.
	public Quaternion defaultRotation = Quaternion.Euler(0,0,0); // Store world 0,0,0 as the rotation. If we want a different rotation on reset, we change the euler rotation.

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		// This code resets the player to its origin position
		// We check every frame is spacebar is pressed, if it is pressed:
		// Set the object this script is attached to to the value stored in default position
		// set the object this script is attached to to the value stored in default position
		// If it isn't pressed we do nothing
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			transform.position = defaultPosition;
			transform.rotation = defaultRotation;
		}
	}
}
