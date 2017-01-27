using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
	private Transform mTransform;

	// Use this for initialization
	void Start ()
	{
		mTransform = transform;
	}

	void KeyboardInput()
	{
		float vertical = Input.GetAxis("Vertical");
		float horizontal = Input.GetAxis("Horizontal");

		mTransform.position += new Vector3(horizontal, 0f, vertical); 
	}
	
	// Update is called once per frame
	void Update ()
	{
		KeyboardInput();
	}
}
