using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocIdle : DocState
{
	//reference to DocFSMClass to get the list of patients currently in the scene
	DocFSMClass m_Doc;

    public DocIdle(DocFSMClass doc)
    {
        m_Doc = doc;
    }

    public override void Enter()
	{
		Debug.Log("IDLE");
	}
	public override void Execute()
	{
		//if there is a patient then the robot will exit the idle state
		//to treat the patient
		//the code finds out the number of patient by referencing the public list 
		//referenced through m_DOc (refer to DocFSMClass to see where the list is from)
        if (m_Doc.patientManager.Patientlist.Count > 0)
        {
			//debug.log for output
            Debug.Log("IDLE");
			//switches to the diagnosis state
            m_Doc.ChangeState(m_Doc.s_Diagnosis);
        }

    }
	public override void Leave()
	{
		 
	}

}
