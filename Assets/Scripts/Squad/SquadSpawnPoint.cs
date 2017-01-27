using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquadSpawnPoint : MonoBehaviour
{
	public SquadMemberClass SquadClass;

	public Vector3 Position
	{
		get;
		private set;
	}

	private void Awake()
	{
		Position = transform.position;
	}
}
