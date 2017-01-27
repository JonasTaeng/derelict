using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
	private AIStateMachine stateMachine = new AIStateMachine();

	void Start ()
	{
	}
	
	void Update ()
	{
		stateMachine.Update();
	}
}
