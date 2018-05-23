using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScaler : MonoBehaviour 
{
	// Variables for default scale size & the rate we want to change the scale of our object. We then expose them to the editor, so designers can easily change the values.
	public float scaleRate;
	public float defaultScale;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Increases size of scale by scaleRate every time button is pressed
		if (Input.GetKeyDown (KeyCode.Equals)) 
		{
			Debug.Log ("Increase Size");
			transform.localScale += new Vector3 (scaleRate, scaleRate, 0);
		}
		// Decreases size of scale by scaleRate every time button is pressed
		if (Input.GetKeyDown (KeyCode.Minus)) 
		{
			Debug.Log ("Decrease Size");
			transform.localScale -= new Vector3 (scaleRate, scaleRate, 0);
		}
		// Resets scale to the default 1,1,1
		if (Input.GetKeyDown (KeyCode.Backspace))
		{
			transform.localScale = new Vector3 (defaultScale, defaultScale, 1);
		}
	}
}
