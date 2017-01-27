using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStateBase
{
	public virtual void OnExit()
	{
	}

	public virtual void OnEnter()
	{
	}
	
	public virtual AIStateBase Update ()
	{
		return null;
	}
}
