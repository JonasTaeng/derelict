using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStateMachine
{
	private AIStateBase currentState;

	public void SetDefaultState(AIStateBase defaultState)
	{
	}
	
	public void Update ()
	{
		if (currentState == null)
		{
			return;
		}

		AIStateBase newState = currentState.Update();

		if (newState != null)
		{
			currentState.OnExit();
			currentState = newState;
			currentState.OnEnter();
		}
	}
}
