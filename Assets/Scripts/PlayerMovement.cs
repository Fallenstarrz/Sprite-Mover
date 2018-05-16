using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 3.0f; // This variable is the default move speed (unity units per update, but when multiplied by deltatime it is roughly units per second)
	public float turnSpeed = 90.0f; // This variable is the default turn rate (degrees per update, but when multiplied by deltatime it is roughly degrees per second)

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame 
	void Update () 
	{
		// This code rotates the character.
		// A quick breakdown of what it does:
		//			transform.Rotate applies to local axes of the object, it says to rotate around (x,y,z)
		//			We set X & Y rotation to 0, because neither of those will change the facing of our object
		// 			We set Z to 1, so it always moves  *** We can get rid of this step, but we decided to keep it for debug purposes in future projects. ***
		//			We multiply 1 by the time that has passed since the last tick 
		//          We multiply that value by our turn speed variable defined above
		//			We multiply that by the return value of Horizontal keypress, this value will always be between -1 and 1 (defaults to 0 when nothing is pressed)
		//			Lastly we multiply that by -1, because we need to flip to result, so our unit rotates in the direction pressed. This is a common issue, so we just need to keep this in mind.
		//		Mathematically you work through from left to right, 1 * time since last update * variable for turn speed (90 for this project) * return of getAxis (default 0) *-1
		// 		We can expect to see no keypress come out to 0, so no rotation will occur. If pressed it will either move a lot, or a little depending on how far the joystick is pressed, or how long the button is held to a max of 100% rotation speed.
		transform.Rotate (0, 0, 1 * Time.deltaTime * turnSpeed * Input.GetAxis("Horizontal") * -1);

		// This code moves the character
		// A quick breakdown of what it does:
		// 			transform.Translate applies to local axes of the object, it says to move the unit (x,y,z)
		//			We set X and Z translation to 0, because neither of those will change in this project, we only want forward movement, not straffing
		//			We set Y to 1 so it always moves *** We can get rid of this step, but we decided to keep it for debug purposes in future projects. ***
		//			We multiply 1 by the time that has passed since last tick
		//			We multiply the value by our move speed variable defined above
		//			Lastly multiply that by the return value of vertical keypress, this value will always be between -1 and 1(defaults to 0 if nothing is pressed)
		//	IMPORTANT: We don't multiply by -1 in this script, because it doesn't invert on startup, if it did we could fix by multiplying by a -1
		//		Mathematically you work through from left to right, 1 * time since last update * variable for move speed (3 for this project) * return of getAxis (default 0)
		// 		We can expect to see no keypress come out to 0, so no movement will occur. If pressed it will either move a lot, or a little depending on how far the joystick is pressed, or how long the button is held to a max of 100% movement speed.
		transform.Translate(0,1* Time.deltaTime * moveSpeed * Input.GetAxis("Vertical"),0);
	}
}
