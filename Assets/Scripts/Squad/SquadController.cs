using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquadController : MonoBehaviour
{
	public SquadFactory SquadFactoryObject;
	public SquadSpawnPoint[] SquadSpawnPoints;

	private List<SquadMember> spawnedSquadMembers = new List<SquadMember>();

	private void Start()
	{
		SquadMemberData[] squadMembers = new SquadMemberData[1];

		squadMembers[0] = new SquadMemberData(SquadMemberClass.Assault, "Droid Droidsson", 1.0f, 0.0f);

		Spawn(squadMembers);
	}

	public void Spawn(SquadMemberData[] squadMembers)
	{
		if (SquadFactoryObject == null)
		{
			Debug.LogErrorFormat("[SquadController]: No SquadFactory has been set!");
			return;
		}

		foreach (SquadMemberData data in squadMembers)
		{
			SquadSpawnPoint spawnPoint = Array.Find(SquadSpawnPoints, a => a.SquadClass == data.SquadClass);

			if (spawnPoint != null)
			{
				GameObject spawnedObject = SquadFactoryObject.Create(data.SquadClass, spawnPoint.Position);

				SquadMember squadMember = spawnedObject.GetComponent<SquadMember>();

				if (squadMember != null)
				{
					spawnedSquadMembers.Add(squadMember);
				}
				else
				{
					Debug.LogErrorFormat("[SquadController]: The spawnedObject has no SquadMember component!");
				}

			}
			else
			{
				Debug.LogErrorFormat("[SquadController]: Could not find a spawn point for the class: {0}", data.SquadClass);
			}
		}
	}

	void SquadGotoLocation(Vector3 location)
	{
		foreach (SquadMember squadMember in spawnedSquadMembers)
		{
			squadMember.Agent.SetDestination(location);
		}
	}

	void SquadMovement()
	{
		if (Input.GetKeyDown(KeyCode.Mouse1))
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit))
			{
				Transform objectHit = hit.transform;

				SquadGotoLocation(hit.point);
			}
		}
	}
	
	void Update ()
	{
		SquadMovement();
	}
}
