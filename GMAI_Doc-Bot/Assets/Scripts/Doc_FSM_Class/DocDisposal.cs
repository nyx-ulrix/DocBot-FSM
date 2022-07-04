using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocDisposal : DocState
{
    //reference to list to remove the bot from list of patients
    DocFSMClass m_Doc;

    public DocDisposal(DocFSMClass doc)
    {
        m_Doc = doc;
    }

    public override void Enter()
    {
        //asks for an input to dispose the bot
        Debug.Log("Press d to dispose bot");

    }
    public override void Execute()
    {
        //if the d key is pressed
        if (Input.GetKey(KeyCode.D))
        {
            //shows that teh bot has been disposed
            Debug.Log("Bot has been disposed");
            //m_Doc.patientManager.Patientlist.Remove(m_Doc.patientManager.Patientlist[0]);
            m_Doc.patientManager.ClearPatient();
            //transition to idle state
            m_Doc.ChangeState(m_Doc.s_Idle);
        }

    }
    public override void Leave()
    {

    }
}
