using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    //the transform variable of the character the camera will follow
    public Transform target;

    //the amount of offset from the character in the x,y and z dimensions
    public float xSpacing;
    public float ySpacing;
    public float zSpacing;
	
	// Update is called once per frame
    void Update ()
    {
        //set the transform of this camera to the x,y and z co-ordinates of the camera, plus offset
        transform.position = new Vector3(target.position.x + xSpacing, target.position.y + ySpacing, target.position.z + zSpacing);
    }
}
