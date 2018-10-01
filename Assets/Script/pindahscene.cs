using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pindahscene : MonoBehaviour {

    public void playgame(string loadScene)
    {
        SceneManager.LoadScene(loadScene);
    }

}

