using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocSelfTerminate : DocState
{
    DocFSMClass m_Doc;

    public DocSelfTerminate(DocFSMClass doc)
    {
        m_Doc = doc;
    }

    public override void Enter()
    {
        //shows that the the doc bot has been terminated (when R key is pressed it will restart the bot)
        Debug.Log("SELF TERMINATED...Please contatct HR for replacement(press R to restart)");


    }
    public override void Execute()
    {
        //if the R key to restart 
        if (Input.GetKey(KeyCode.R))
        {
            //transitions to Idle state
            m_Doc.ChangeState(m_Doc.s_Idle);
            //disposes of the infectious bot 
            m_Doc.patientManager.ClearPatient();

        }
    }
    public override void Leave()
    {

    }

}
