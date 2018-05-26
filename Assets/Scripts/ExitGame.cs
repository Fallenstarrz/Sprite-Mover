using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		// This closes the application cleanly
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Application.Quit();
			Debug.Log ("Escape Pressed, Quitting Application");
		}
	}
}
