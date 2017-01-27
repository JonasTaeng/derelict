using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum SquadMemberClass
{
	Assault,
	Heavy,
	Melee
}

public class SquadMemberData
{
	public SquadMemberData(SquadMemberClass squadClass, string name, float accuracy, float evasion)
	{
		SquadClass = squadClass;
		Name = name;
		Accuracy = accuracy;
		Evasion = evasion;
	}

	public SquadMemberClass SquadClass
	{
		get;
		private set;
	}

	public string Name
	{
		get;
		private set;
	}

	public float Accuracy
	{
		get;
		private set;
	}

	public float Evasion
	{
		get;
		private set;
	}
}
