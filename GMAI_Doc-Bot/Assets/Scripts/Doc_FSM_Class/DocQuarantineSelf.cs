using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocQuarantineSelf : DocState
{
	DocFSMClass m_Doc;

	public DocQuarantineSelf(DocFSMClass doc)
	{
		m_Doc = doc;
	}

	public override void Enter()
	{

	}
	public override void Execute()
	{
		//if the reboot worked
		if (rebootSuccessRate())
		{
			//shows that the reboot work
			Debug.Log("QUARANTINE SELF...Trying to reboot... reboot successful");
			//transition to idle state
			m_Doc.ChangeState(m_Doc.s_Idle);
		}

		else
		{
			//shows that the reboot failed
			Debug.Log("QUARANTINE SELF...Trying to reboot... reboot unsuccessful");
			//transitions to self terminate state
			m_Doc.ChangeState(m_Doc.s_SelfTerminate);
		}
	}
	public override void Leave()
	{

	}

	//random generator to see if the reboot worked
	private bool rebootSuccessRate()
	{
		if (Random.Range(1, 10) >= 5f)
		{
			return true;
		}
		return false;
	}
}
