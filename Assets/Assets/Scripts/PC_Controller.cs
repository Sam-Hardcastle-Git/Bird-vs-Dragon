using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC_Controller : MonoBehaviour
{
    #region variables

    //the speed the playable character moves forward at
    private float speed = 5;

    //the length of time the boost powerup lasts for
    private float boost_timer = 2;

    #endregion variables

    #region functions
    void Update ()
    {
        Fly();

        //Start the countdown timer for the booster to stop working
        if (speed == 15)
        {
            BoostSpeedEffectWearsOff();
        }
	}

    private void Fly()
    {
        //the playable character is being moved forawrd
        transform.position += Vector3.forward * Time.deltaTime * speed;

        #region moving with Input.GetKey
        #region Left

        //When the left arrow if pressed and the Playable Character is inside the left boundary
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -100)
        {
            //Move left
            transform.position += Vector3.left * speed * Time.deltaTime;

            //Rotate in the direction moved
            transform.eulerAngles = new Vector3(transform.rotation.x, -30, transform.rotation.z);
        }

        //Otherwise set the rotation to neutral
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {            
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        #endregion Left

        #region Right

        //When the right arrow if pressed and the Playable Character is inside the right boundary
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= -60)
        {
            //Move Right
            transform.position += Vector3.right * speed * Time.deltaTime;

            //Rotate in the direction moved
            transform.eulerAngles = new Vector3(transform.rotation.x, 30, transform.rotation.z);
        }

        //Otherwise set the rotation to neutral
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        #endregion Right

        #region up

        //When the up arrow if pressed and the Playable Character is inside the up boundary
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 26)
        {
            //Move Up
            transform.position += Vector3.up * speed * Time.deltaTime;

            //Rotate in the direction moved
            transform.eulerAngles = new Vector3(-30, transform.rotation.y, transform.rotation.z);          
        }

        //Otherwise set the rotation to neutral
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        #endregion up

        #region down

        //When the down arrow if pressed and the Playable Character is inside the down boundary
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= -15)
        {
            //Move Down
            transform.position += Vector3.down * speed * Time.deltaTime;

            //Rotate in the direction moved
            transform.eulerAngles = new Vector3(30, transform.rotation.y, transform.rotation.z);            
        }

        //Otherwise set the rotation to neutral
        else if (Input.GetKeyUp(KeyCode.DownArrow) && transform.position.x <= -35)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        
        #endregion down

        #endregion moving with Input.GetKey
    }

    public void BoostSpeed()
    {
        //increase Playable Character speed
        speed = 15f;
    }

    private void BoostSpeedEffectWearsOff()
    {
        //decrease boost timer
        boost_timer -= 1 * Time.deltaTime;

        //if the boost timer runs out, the effects of the boost wear off
        if(boost_timer <= 0)
        {
            //return speed to normal
            speed = 5;

            //boost timer is reset
            boost_timer = 1;
        }
    }
    #endregion functions
}
