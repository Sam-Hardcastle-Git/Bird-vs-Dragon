using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostBirdSpeed : MonoBehaviour
{
    #region variables
    //the boostSound audioclip
    public AudioClip boostSound;

    #endregion variables

    #region functions
    void OnTriggerEnter(Collider col)
    {
        #region get the Playable Character
        PC_Controller PC = col.gameObject.GetComponent<PC_Controller>();

        #endregion get PC reference

        #region if the Playable Character is there when the powerup gets hit, boost its speed
        if (PC)
        {
            //call the boostSpeed function from the Playable Character
            PC.BoostSpeed();

            //play sound
            AudioSource.PlayClipAtPoint(boostSound, transform.position);

            //destroy the boost powerup
            Destroy(gameObject);
        }
        #endregion if the Playable Character is there when the powerup gets hit, boost its speed
    }

    #endregion functions
}
