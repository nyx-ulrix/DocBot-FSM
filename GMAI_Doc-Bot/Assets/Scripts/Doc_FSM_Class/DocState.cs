using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DocState
{
	// These variables are protected, since they must be
	// inherited by the subclasses. Private vars are not
	// inherited, and we shouldn't make them public,
	// since they are internal variables.

	protected DocFSMClass FSM;

	public virtual void Enter()
	{
		Debug.Log("Entered a new state");
	}
	public virtual void Execute()
	{

	}
	public virtual void Leave()
	{

	}

}
