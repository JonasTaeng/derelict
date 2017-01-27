using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SquadMember : MonoBehaviour
{
	public NavMeshAgent Agent;
	public Animator Anim;

	private SquadMemberData mMemberData;

	private int speedVar;

	public void SetSquadMemberData(SquadMemberData memberData)
	{
		mMemberData = memberData;
	}

	// Use this for initialization
	void Start ()
	{
		speedVar = Animator.StringToHash("Speed");
	}
	
	// Update is called once per frame
	void Update ()
	{
		Anim.SetFloat(speedVar, Agent.velocity.magnitude);
	}
}
