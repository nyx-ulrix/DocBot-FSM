using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientManager : MonoBehaviour
{
    //to store the patient prefab
    public GameObject Patient;
    //the list that stores the list of patients that are in the hospital
    public List<GameObject> Patientlist;


    //function to spawn patients
    public void Spawn(string Tag)
    {
        //spawns patient prefab
        GameObject current = Instantiate(Patient, new Vector3(0, 0, 1), Quaternion.identity) as GameObject;
        //changes the patients tag to whatever is written in the inspector
        current.tag = Tag;
        //changes the name of the patient to be the same as the tag (for easy reference)
        current.name = Tag;
        //adds teh patientss to the patient list
        Patientlist.Add(current);
    }

    //function to remove the patient from the list of patients
    public void ClearPatient()
    {
        //destroys the patient gameobject instance
        Destroy(Patientlist[0].gameObject);
        //removes the patient from the list
        Patientlist.Remove(Patientlist[0]);
    }

}
