using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocChecking : DocState
{
	DocFSMClass m_Doc;

	public DocChecking(DocFSMClass doc)
	{
		m_Doc = doc;
	}

	public override void Enter()
	{
		//shows the word CHECKING when entering the state
		Debug.Log("CHECKING");
	}
	public override void Execute()
	{
		//if the inventory has more than one of the part that is needed for repair
		if (m_Doc.Inventory.CheckComponent(m_Doc.patientManager.Patientlist[0].tag) > 0)
		{
			//shows that there is enough stocks 
			Debug.Log("CHECKING...Enough stocks");
			//code removes 1 from the stock that was used by using tag to find which component was used(check inventory manager script)
			m_Doc.Inventory.UseComponent(m_Doc.patientManager.Patientlist[0].tag);
			//transitions into the treatment state
			m_Doc.ChangeState(m_Doc.s_Treatment);

		}

		//otherwise if the inventory does not have enough stocks
        else
        {
			//shows that there are not enough stocks
			Debug.Log("CHECKING...Not enough stocks going to restock");
			//transition to restock state
			m_Doc.ChangeState(m_Doc.s_Restock);
        }

	}
	public override void Leave()
	{

	}

}
