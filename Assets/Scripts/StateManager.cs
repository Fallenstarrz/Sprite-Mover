using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour {

	public GameObject player; // Create a global empty object variable, in the editor we store PlayerCharacter here, so we can use this reference to make changes to PlayerCharacter

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		// This script will deactivate the entire object
		if (Input.GetKeyDown (KeyCode.Q))  // If Q is pressed
		{
			player.SetActive (!player.activeInHierarchy); // get reference to PlayerCharacter through the player variable and access it's SetActive function, now we set it to the inverse of it's current state
														  // this state is found by searching the hierarchy to find it's currect active state.
		}
	}
}
