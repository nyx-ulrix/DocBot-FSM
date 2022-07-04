using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocTreatment : DocState
{
    DocFSMClass m_Doc;

    public DocTreatment(DocFSMClass doc)
    {
        m_Doc = doc;
    }

    public override void Enter()
    {
        //if the treatment is successful
        if (treatmentSuccessRate())
        {
            //shows that the patient is okay
            Debug.Log("TREATMENT...Patient is okay now");
            //transitions to release state
            m_Doc.ChangeState(m_Doc.s_Release);
        }
        //if the tretment is unsuccesful
        else
        {
            //
            Debug.Log("TREATMENT...Patient died");
            Debug.Log("patient is dead can we dismantle the bot for parts? Y /N");

        }

    }
    public override void Execute()
    {
        //if Y key is pressed
        if (Input.GetKey(KeyCode.Y))
        {
            //transitions to dismantle state
            m_Doc.ChangeState(m_Doc.s_Dismantle);

        }

        //if N key is pressed
        else if (Input.GetKey(KeyCode.N))
        {
            //transition to dispose state
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
