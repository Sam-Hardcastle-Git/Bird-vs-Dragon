using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreDisplay : MonoBehaviour
{
    #region variables
    //final score
    public int finalScore;

    //final score text
    public Text finalScoreText;

    //high score
    public int highScore;

    //high score text
    public Text highScoreText;

    #endregion variables

    #region functions
    void Start()
    {
        UpdateTheScore();
    }

    void UpdateTheScore()
    {
        //Fetch the scores from the player prefabs
        highScore = PlayerPrefabsManager.GetHighScoreKey();
        finalScore = PlayerPrefabsManager.GetScoreKey();

        //Display scores
        highScoreText.text = "High Score: " + highScore.ToString();
        finalScoreText.text = "Your Score: " + finalScore.ToString();
    }
    #endregion functions
}
