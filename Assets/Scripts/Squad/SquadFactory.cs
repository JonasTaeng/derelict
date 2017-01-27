using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquadFactory : MonoBehaviour
{
	public GameObject[] Prefabs;

	public GameObject Create(SquadMemberClass squadClass, Vector3 position)
	{
		string prefabName = squadClass.ToString();

		GameObject prefab = Array.Find(Prefabs, (a) => prefabName == a.name);

		if (prefab == null)
		{
			Debug.LogErrorFormat("[SquadFactory]: Could not find an object with the name {0}", prefabName);
			return null;
		}

		GameObject newSquadMember = Instantiate(prefab, position, Quaternion.identity);

		return newSquadMember;
	}
}
