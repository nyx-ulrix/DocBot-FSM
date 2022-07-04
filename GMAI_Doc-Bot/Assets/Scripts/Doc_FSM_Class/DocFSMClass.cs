using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocFSMClass : MonoBehaviour
{
    //reference to the list inside teh PatientSpawn sscript (assigned in inspector)
    public PatientManager patientManager;
    //reference the inventory
    public InventoryManager Inventory;

    //reference to the other class scripts
    public DocState s_Idle { get; set; } = null;
    public DocState s_Diagnosis { get; set; } = null;
    public DocState s_Checking { get; set; } = null;
    public DocState s_Restock { get; set; } = null;
    public DocState s_Treatment { get; set; } = null;
    public DocState s_Release { get; set; } = null;
    public DocState s_Dismantle { get; set; } = null;
    public DocState s_Dispose { get; set; } = null;
    public DocState s_Quarantine { get; set; } = null;  
    public DocState s_VirusTreatment { get; set; } = null;
    public DocState s_QuarantineSelf { get; set; } = null;
    public DocState s_SelfTerminate { get; set; } = null;

    DocState m_currentState;

    // Start is called before the first frame update
    void Start()
    {
        s_Idle = new DocIdle(this);
        s_Diagnosis = new DocDiagnosis(this);
        s_Checking = new DocChecking(this);
        s_Restock = new DocRestock(this);
        s_Treatment = new DocTreatment(this);
        s_Release = new DocRelease(this);
        s_Dismantle = new DocDismantle(this);
        s_Dispose = new DocDisposal(this);
        s_Quarantine = new DocQuarantine(this);
        s_VirusTreatment = new DocVirusTreatment(this);
        s_QuarantineSelf = new DocQuarantineSelf(this);
        s_SelfTerminate = new DocSelfTerminate(this);

        m_currentState = s_Idle;
    }

    // Update is called once per frame
    void Update()
    {
        m_currentState.Execute();
    }

    public void ChangeState(DocState nextState)
    {
        m_currentState.Leave();
        m_currentState = nextState;
        m_currentState.Enter();
    }
}
