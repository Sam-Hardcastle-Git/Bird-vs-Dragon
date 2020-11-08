using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    #region variables
    //A signal that the finish line has been crossed
    public bool Won = false;

    #endregion variables

    #region functions
    
    void OnTriggerEnter(Collider col)
    {
        #region get PC reference

        //Find the class of the Playable Character when colliding with it
        PC_Controller PC = col.gameObject.GetComponent<PC_Controller>();
        #endregion get PC reference

        #region if the Playable Character crosses the line, signal that the game has been won
        if (PC)
        {
            Won = true;
        }
        #endregion if the Playable Character crosses the line, signal that the game has been won
    }
    #endregion functions

}
