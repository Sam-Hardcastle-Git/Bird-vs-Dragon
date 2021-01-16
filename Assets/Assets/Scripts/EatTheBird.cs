using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatTheBird : MonoBehaviour
{
    //a reference to the level manager class
    private LevelManager levelManager;

    void Start()
    {
        //find the level manager GameObject
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter(Collider col)
    {
        #region get PC reference
        //Find the class of the Playable Character when colliding with it
        PC_Controller PC = col.gameObject.GetComponent<PC_Controller>();

        #endregion get PC reference

        #region if the Dragon catches the Playable Character, transition to the Lose screen
        if (PC)
        {
            levelManager.changeScene("Lose");            
        }
        #endregion if the Dragon catches the Playable Character, transition to the Lose screen
    }

}
