using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreDisplay : MonoBehaviour
{
    //scores
    public int finalScore;
    public int highScore;

    //texts
    public Text finalScoreText;
    public Text highScoreText;
 
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
}
