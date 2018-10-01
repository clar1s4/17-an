using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript2 : MonoBehaviour {

    private float time = 0;
    private Image ImgBox;
    private CanvasManager canvasmgr;
    private soal soalmgr;
    public Sprite pic2;
    public Sprite pic1;
	// Use this for initialization
	void Start () {
        canvasmgr = GameObject.Find("Manager").GetComponent<CanvasManager>();
		soalmgr = GameObject.Find("Manager").GetComponent<soal>();
        ImgBox = GameObject.Find("StartCount").GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time >= 1 && time <=2)
        {
            ImgBox.sprite = pic2;
        }
        else if(time >= 2 && time <=3)
        {
            ImgBox.sprite = pic1;
        }
        else if(time >= 3)
        {
            canvasmgr.StartCanvasOff();
        }
	}
}
