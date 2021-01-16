using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{    
    //A signal that the finish line has been crossed
    public bool Won = false;
           
    void OnTriggerEnter(Collider col)
    {       
        //Find the class of the Playable Character when colliding with it
        PC_Controller Pc = col.gameObject.GetComponent<PC_Controller>();        
        
        if (Pc)
        {
            Won = true;
        }        
    }    
}
