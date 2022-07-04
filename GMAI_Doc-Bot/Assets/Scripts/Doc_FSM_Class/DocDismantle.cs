using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocDismantle : DocState
{
    DocFSMClass m_Doc;

    public DocDismantle(DocFSMClass doc)
    {
        m_Doc = doc;
    }

    public override void Enter()
    {
        //shows that the bot is going through the dismantling process
        Debug.Log("DISMANTLING");

    }
    public override void Execute()
    {
        //runs DismatleProtocol (form InventoryManager) to add the parts that are not broken after dismantling
        m_Doc.Inventory.DismantleProtocol(m_Doc.patientManager.Patientlist[0].tag);
        //change the state to dispose state
        m_Doc.ChangeState(m_Doc.s_Dispose);

    }
    public override void Leave()
    {

    }
}
