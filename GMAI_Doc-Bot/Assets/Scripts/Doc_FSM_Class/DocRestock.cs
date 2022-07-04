using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocRestock : DocState
{
    DocFSMClass m_Doc;

    public DocRestock(DocFSMClass doc)
    {
        m_Doc = doc;
    }

    public override void Enter()
    {
        //asks for an input
        Debug.Log("Do you want to restock? Y/N");

    }
    public override void Execute()
    {
        //if Y is pressed
        if (Input.GetKey(KeyCode.Y))
        {
            //shows that the inventory is restocking
            Debug.Log("RESTOCKING");
            //restocks the item that isnt available by using what is on the tag of the current patient
            m_Doc.Inventory.Restock(m_Doc.patientManager.Patientlist[0].tag);
            //transitions to the treatment state
            m_Doc.ChangeState(m_Doc.s_Treatment);

        }

        //if N is pressed
        else if (Input.GetKey(KeyCode.N))
        {
            //shows that the restock didnt work
            Debug.Log("Unable to restock");
            //transitions to the dismantle state
            m_Doc.ChangeState(m_Doc.s_Dispose);
        }

    }
    public override void Leave()
    {

    }

}
