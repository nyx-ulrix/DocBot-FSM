using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocVirusTreatment : DocState
{
	DocFSMClass m_Doc;

	public DocVirusTreatment(DocFSMClass doc)
	{
		m_Doc = doc;
	}

	public override void Enter()
	{

	}
	public override void Execute()
	{
		//if the treatment is successful
		if (treatmentSuccessRate())
		{
			//shows that the patient is okay
			Debug.Log("VIRUS TREATMENT...Treatment SUCCESSFUL");
			//transitions to release state
			m_Doc.ChangeState(m_Doc.s_Release);
		}

		//if the tretment is unsuccesful
		else
		{
			//shows that teh treatment failed
			Debug.Log("VIRUS TREATMENT...Treatment FAILED");
			//transitions to dispose state
			m_Doc.ChangeState(m_Doc.s_Dispose);
		}

	}
	public override void Leave()
	{

	}

	//calculates the chances of the virus treatment being successful
	private bool treatmentSuccessRate()
	{
		if (Random.Range(1, 10) >= 5f)
		{
			return true;
		}
		return false;
	}
}
