using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver2 : MonoBehaviour {
	private soal soalmgr;
	private Image imgbox;
	public Sprite winpic;
	public Sprite losepic;

	// Use this for initialization
	void Start () {
		soalmgr = GameObject.Find("Manager").GetComponent<soal>();
		imgbox = GameObject.Find("result").GetComponent<Image>();
		//UpdatePic();
	}

	void Update()
	{
		if (soalmgr.isWin)
		{
			imgbox.sprite = winpic;
		}
		else if (soalmgr.isLose)
		{
			imgbox.sprite = losepic;
		}
	}
}
