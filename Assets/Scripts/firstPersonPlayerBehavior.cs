using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstPersonPlayerBehavior : MonoBehaviour
{
	public float movementSpeed = 5.0f;
	
	// Use this for initialization
	void Start () 
	{
			
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		//mouse
		float rotLeftRight = Input.GetAxis("Mouse X");
		float rotUpDown = Input.GetAxis("Mouse Y");
		
		transform.Rotate(-rotUpDown, rotLeftRight, 0);
		
		//WASD movement
		float forwardSpeed = Input.GetAxis("Vertical")* movementSpeed;
		float sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;
		
		
		Vector3 speed = new Vector3(sideSpeed, 0, forwardSpeed);

		CharacterController cc = GetComponent<CharacterController>();

		cc.SimpleMove(speed);
		
		
	}
}
