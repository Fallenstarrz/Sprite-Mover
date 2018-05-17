using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptManager : MonoBehaviour {

	private PlayerMovement movement; // Get a reference to PlayerMovement and name it movement

	// Use this for initialization
	void Start () 
	{
		movement = GetComponent<PlayerMovement>(); // Tell movement that it is going to hold the PlayerMovement script component
	}
	
	// Update is called once per frame
	void Update () 
	{
		// This script will toggle the movement script on and off
		if (Input.GetKeyDown (KeyCode.P)) // Check to see if P was pressed down and if it was then do what is inside the if's body
		{
			movement.enabled = !movement.enabled; // Access the movement script's enabled function and set it to the inverse(opposite) of whatever it is currently set to. On/Off
		}
	}
}
