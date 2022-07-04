using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocDiagnosis : DocState
{
    //reference to DocFSMClass to get the list of patients currently in the scene to get
    //info on a specific patient
    DocFSMClass m_Doc;

    public DocDiagnosis(DocFSMClass doc)
    {
        m_Doc = doc;
    }

    public override void Enter()
    {

    }
    public override void Execute()
    {
        //if the patient has a virus or "outbreak" which is just a virus that is contagious
        if (m_Doc.patientManager.Patientlist[0].tag == "Virus" ||
            m_Doc.patientManager.Patientlist[0].tag == "Outbreak")
        {
            //debug output
            Debug.Log("DIAGNOSIS...patient is infected with a virus");
            //transition to quarantine state
            m_Doc.ChangeState(m_Doc.s_Quarantine);

        }

        //if the problem with the patient is non virus related
        else
        {
            //debug output
            Debug.Log("DIAGNOSIS");
            //transition into checking inventory state
            m_Doc.ChangeState(m_Doc.s_Checking);
        }

    }
    public override void Leave()
    {

    }

}
