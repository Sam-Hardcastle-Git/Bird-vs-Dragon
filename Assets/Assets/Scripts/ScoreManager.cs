using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{   
    //the current score value
    public int score = 0;

    //the text that will display the score
    public Text scoreText;

    //a reference to the finish line class
    private Finish finish;

    //a reference to the level manager class
    private LevelManager levelManager;

    void Start()
    {
        //find the Finish GameObject
        finish = GameObject.FindObjectOfType<Finish>();

        //find the level manager GameObject
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    void Update()
    {
        //update the score text with the current score
        scoreText.text = "Score: " + score;

        updateScore();
    }

    public void increaseScore(int point)
    {
        //add points to the overall score
        score += point;

        //display the score
        scoreText.text = score.ToString();
    }

    public void updateScore()
    {
        #region pass score into the final scene and set high score when the score exceeds the current high score
        if (finish.Won)
        {
            //pass the score into the score player prefab
            PlayerPrefabsManager.SetScoreKey(score);

            #region new high score

            //If the score is higher than the high score, se this value as the new high score
            if (score >= PlayerPrefabsManager.GetHighScoreKey())
            {
                PlayerPrefabsManager.SetHighScoreKey(score);
            }
            #endregion new high score

            //transition to the win screen
            levelManager.changeScene("Win");
        }
        #endregion pass score into the final scene and set high score when the score exceeds the current high score
    }
}
