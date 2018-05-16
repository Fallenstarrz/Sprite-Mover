using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 3.0f;
	public float turnSpeed = 2.0f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (0, 0, 1 * Time.deltaTime * turnSpeed * Input.GetAxis("Horizontal") * -1);
		transform.Translate(0,1* Time.deltaTime * moveSpeed * Input.GetAxis("Vertical"),0);
	}
}
