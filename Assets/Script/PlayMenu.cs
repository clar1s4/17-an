using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour {

    public void Game1(string loadScene)
    {
        SceneManager.LoadScene(loadScene);
    }
}
