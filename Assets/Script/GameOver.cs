	using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    private SpamManager spammgr;
    private Image imgbox;
    public Sprite winpic;
    public Sprite losepic;

    // Use this for initialization
    void Start () {
        spammgr = GameObject.Find("Manager").GetComponent<SpamManager>();
        imgbox = GameObject.Find("result").GetComponent<Image>();
        //UpdatePic();
    }

    void Update()
    {
        if (spammgr.isWin)
        {
            imgbox.sprite = winpic;
        }
        else if (spammgr.isLose)
        {
            imgbox.sprite = losepic;
        }
    }
}
