using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    //integer that stores the Motor stock
    public int Motor;
    //integer that stores the CPU stock
    public int CPU;
    //integer that stores the Sensor stock
    public int Sensor;
    //integer that stores the Camera stock
    public int Cam;

    // Start is called before the first frame update
    void Start()
    {
        //sets the ammount of stock that is in the inventory at the start
        Motor = 10;
        CPU = 10;
        Sensor = 10;
        Cam = 10;
    }

    //function to check the number of each componenets
    public int CheckComponent(string needed)
    {
        //the needed is reffering to the tag that the current patient has to check for which item needs to be found
        if (needed == "Motor")
        {
            //reutrns the ammount of that item is in the inventory
            return Motor;

        }
        //the other else if statements does the same thing but for different items
        else if (needed == "CPU")
        {
            return Cam;

        }

        else if (needed == "Sensor")
        {
            return Sensor;

        }

        //checks for the camera stock cant be an else if becuse the function has to return an integer
        else
        {
            return Cam;

        }
    }

    //function to remove the used component from the stock
    public void UseComponent(string needed)
    {
        //the needed is reffering to the tag that the current patient has to check for which item has been used
        if (needed == "Motor")
        {
            //removes one item from the inventory  
            Motor = Motor - 1;

        }

        //the other else if statements does the same thing but for different items
        else if (needed == "CPU")
        {
            CPU = CPU - 1;

        }

        else if (needed == "Sensor")
        {
            Sensor = Sensor - 1;

        }

        else if (needed == "Camera")
        {
            Cam = Cam - 1;

        }
        
    }

    //function to restock the items
    public void Restock(string needed)
    {
        //the needed is reffering to the tag that the current patient has to check for which item needs to be restocked
        if (needed == "Motor")
        {
            //restocks item
            Motor = Motor + 10;

        }

        //the other else if statements does the same thing but for different items
        else if (needed == "CPU")
        {
            CPU = CPU + 10;

        }

        else if (needed == "Sensor")
        {
            Sensor = Sensor + 10;

        }

        else if (needed == "Camera")
        {
            Cam = Cam + 10;

        }

    }

    //adds one of each of the non broken part in a bot back into the inventory
    public void DismantleProtocol(string current)
    {
        //current is reffering to the tag that the current patient has to check for which item can be dismantled and reused
        if (current == "Motor")
        {
            CPU = CPU + 1;
            Sensor = Sensor + 1;
            Cam = Cam + 1;

        }

        //the other else if statements does the same thing but for different items
        else if (current == "CPU")
        {
            Motor = Motor + 1;
            Sensor = Sensor + 1;
            Cam = Cam + 1;

        }

        else if (current == "Sensor")
        {
            Motor = Motor + 1;
            CPU = CPU + 1;
            Cam = Cam + 1;

        }

        else if (current == "Camera")
        {
            Motor = Motor + 1;
            CPU = CPU + 1;
            Sensor = Sensor + 1;

        }

    }


}
