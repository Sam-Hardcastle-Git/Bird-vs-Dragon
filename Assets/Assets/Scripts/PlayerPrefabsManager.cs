using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefabsManager : MonoBehaviour
{   
    //The keys for score and high score
    const string SCORE_KEY = "score_key";
    const string HIGH_SCORE_KEY = "high_score_key";     

    //The Score Setter
    public static void SetScoreKey(int score)
    {
        PlayerPrefs.SetInt(SCORE_KEY, score);
    }

    //The Score Getter
    public static int GetScoreKey()
    {
        return PlayerPrefs.GetInt(SCORE_KEY);
    }        

    //The High Score Setter
    public static void SetHighScoreKey(int score)
    {
        PlayerPrefs.SetInt(HIGH_SCORE_KEY, score);
    }

    //The High Score Getter
    public static int GetHighScoreKey()
    {
        return PlayerPrefs.GetInt(HIGH_SCORE_KEY);
    }    
}
