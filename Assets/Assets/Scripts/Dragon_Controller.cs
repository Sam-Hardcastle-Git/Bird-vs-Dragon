using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon_Controller : MonoBehaviour
{
    #region variables
    //the dragons speed value
    private float speed = 8;

    //the transform of the Playable Character
    private Transform Bird;

    #endregion variables

    #region functions
    void Start()
    {
        //find the Playable Character from the hierarchy
        Bird = GameObject.Find("Bird").transform;
    }

    void Update()
    {
        Follow();
    }

    private void Follow()
    {
        //push the dragon forward
        transform.position += transform.forward * Time.deltaTime * speed;

        //constantly face the Playable Character
        transform.LookAt(Bird);
    }

    #endregion functions
}
