using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseWinSound : MonoBehaviour
{
    //The sound that will play at the start of the Win/Lose Screen
    public AudioClip winLoseSound;

    //Use this for initialization
    void Start ()
    {
        //play sound
        AudioSource.PlayClipAtPoint(winLoseSound, transform.position);
    }
}
