using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour {
    public GameObject StartCanvas;
    public GameObject InGameCanvas;
    public GameObject PauseCanvas;
    public GameObject GameOverCanvas;

	// Use this for initialization
	void Start () {
        StartCanvas.SetActive(true);
        InGameCanvas.SetActive(false);
        PauseCanvas.SetActive(false);
        GameOverCanvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameOver()
    {
        StartCanvas.SetActive(false);
        InGameCanvas.SetActive(false);
        PauseCanvas.SetActive(false);
        GameOverCanvas.SetActive(true);
    }
    public void StartCanvasOff()
    {
        StartCanvas.SetActive(false);
        InGameCanvas.SetActive(true);
        PauseCanvas.SetActive(false);
        GameOverCanvas.SetActive(false);
    }
}
