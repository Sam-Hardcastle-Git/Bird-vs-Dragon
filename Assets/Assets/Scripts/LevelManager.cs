using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    //change the scene based on the scene name
    public void changeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
