using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreStartScreen : MonoBehaviour
{
    //high score
    public int highScore;

    //high score text
    public Text highScoreText;

    // Use this for initialization
    void Start()
    {
        UpdateTheScore();
    }

    void UpdateTheScore()
    {
        //get the scores from the player prefabs
        highScore = PlayerPrefabsManager.GetHighScoreKey();

        //display scores
        highScoreText.text = "High Score: " + highScore.ToString();
    }
}
