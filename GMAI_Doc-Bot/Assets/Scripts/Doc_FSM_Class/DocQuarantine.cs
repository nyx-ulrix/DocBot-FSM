using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocQuarantine : DocState
{
    //reference to DocFSMClass to get the list of patients currently in the scene to get
    //info on a specific patient
    DocFSMClass m_Doc;

    public DocQuarantine(DocFSMClass doc)
    {
        m_Doc = doc;
    }

    public override void Enter()
    {
        //shows that the bot has transitioned to quarantine state
        Debug.Log("QUARANTINE");
    }
    public override void Execute()
    {
        //after being quarantined check if the patients virus is contagious if it is not
        if (m_Doc.patientManager.Patientlist[0].tag == "Virus")
        {
            //shows that the virus is not contagious
            Debug.Log("Diagnosis on virus... virus is non contagious");
            //transitiont to virus treatment state
            m_Doc.ChangeState(m_Doc.s_VirusTreatment);
        }

        //after being quarantined check if the patients virus is contagious if it is
        else if (m_Doc.patientManager.Patientlist[0].tag == "Outbreak")
        {
            //shows that the virus is contagious
            Debug.Log("Diagnosis on virus... virus is non contagious");
            //transition to quarantine self state
            m_Doc.ChangeState(m_Doc.s_QuarantineSelf);
        }

    }
    public override void Leave()
    {

    }
}
