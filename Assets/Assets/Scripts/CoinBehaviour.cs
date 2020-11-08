using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    #region variables
    //the amount of points the coin will give
    private int points = 20;

    //a reference to the score manager class
    private ScoreManager scoreManager;

    //the sound that the coin will make when collected
    public AudioClip coinSound;

    #endregion variables

    #region functions
    void Start()
    {
        //find the score manager
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }

    void OnTriggerEnter(Collider col)
    {
        #region get PC reference
        //Find the class of the Playable Character when colliding with it
        PC_Controller PC = col.gameObject.GetComponent<PC_Controller>();

        #endregion get PC reference

        #region if the Playable Character is there when the coin gets hit, the score is increased and the coin is destroyed
        if (PC)
        {
            //call the increaseScore function from the score manager to add to the score
            scoreManager.increaseScore(points);

            //play coin sound
            AudioSource.PlayClipAtPoint(coinSound, transform.position);

            //destroy coin gameObject
            Destroy(gameObject);
        }
        #endregion if the Playable Character is there when the coin gets hit, the score is increased and the coin is destroyed
    }

    #endregion functions

}
