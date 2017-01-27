using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AIStateTransitionType
{
	Exit,
	OnTop
}

public class AIStateTransition
{
	public AIStateTransition(AIStateBase newState, AIStateTransitionType transitionType)
	{
		NewState = newState;
		TransitionType = transitionType;
	}

	public AIStateBase NewState;
	public AIStateTransitionType TransitionType;
}
