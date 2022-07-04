using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocRelease : DocState
{
    //reference to list to remove the bot from list of patients
    DocFSMClass m_Doc;

    public DocRelease(DocFSMClass doc)
    {
        m_Doc = doc;
    }

    public override void Enter()
    {
        Debug.Log("Press c to collect your bot");

    }
    public override void Execute()
    {
        //when c key is pressed
        if (Input.GetKey(KeyCode.C))
        {
            //shows that the bot has been released
            Debug.Log("thank you for trusting us with repairs");
            m_Doc.patientManager.ClearPatient();
            //transition to idle state
            m_Doc.ChangeState(m_Doc.s_Idle);
        }

    }
    public override void Leave()
    {

    }
}
