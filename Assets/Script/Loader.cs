using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loader : MonoBehaviour {

	// Use this for initialization
	private soal soalmgr;
	private CanvasManager canvasmgr;
	private Animator chara;
	private GameObject BGTiang;
	private Vector3 temp;
	private int curIndex = 0;
	private int salah = 0;
	private int betul = 0;
	private bool isPanjat = false;
	private bool isJatuh = false;

	void Start () {
		canvasmgr = GameObject.Find("Manager").GetComponent<CanvasManager>();
		soalmgr = GameObject.Find ("Manager").GetComponent <soal> ();
		chara = GameObject.Find ("Chara").GetComponent<Animator>();
		BGTiang = GameObject.Find ("Item");

		LoadSoal (curIndex++);
	}
	
	// Update is called once per frame
	void Update () {
		if (isPanjat) {
			BGTiang.transform.position = Vector3.MoveTowards(BGTiang.transform.position, temp, Time.deltaTime*10);

		}

		if (isJatuh) {
			BGTiang.transform.position = Vector3.MoveTowards(BGTiang.transform.position, temp, Time.deltaTime*10);
		}

		if (salah == 3) {
			soalmgr.isLose = true;
			Jatuh ();
			if (BGTiang.transform.position.y >= -2)
				canvasmgr.GameOver();

		}
		else if(betul == 5){
			soalmgr.isWin = true;
			if(BGTiang.transform.position.y <= -22)
				canvasmgr.GameOver();

		}
	}

	public void LoadSoal(int index){
		Debug.Log (index);
		Text BoxSoal = GameObject.Find ("BoxSoal").GetComponent<Text> ();
		Text Jawaban1 = GameObject.Find ("Jawaban1").GetComponent<Text> ();
		Text Jawaban2 = GameObject.Find ("Jawaban2").GetComponent<Text> ();
		Text Jawaban3 = GameObject.Find ("Jawaban3").GetComponent<Text> ();
		Text Jawaban4 = GameObject.Find ("Jawaban4").GetComponent<Text> ();
		BoxSoal.text = soalmgr.arrSoal [soalmgr.indexSoal [index], 0];
		Jawaban1.text = soalmgr.arrSoal [soalmgr.indexSoal [index], 1];
		Jawaban2.text = soalmgr.arrSoal [soalmgr.indexSoal [index], 2];
		Jawaban3.text = soalmgr.arrSoal [soalmgr.indexSoal [index], 3];
		Jawaban4.text = soalmgr.arrSoal [soalmgr.indexSoal [index], 4];
	}

	public void NextSoal(int indexJawaban){
		CekJawaban (indexJawaban);
		LoadSoal (curIndex++);
	}

	public void CekJawaban(int indexJawaban){
		if (indexJawaban + 1 == soalmgr.kunci [soalmgr.indexSoal [curIndex - 1]]) {
			betul++;
			Panjat ();
		}
		else
			salah++;
	}

	public void Panjat(){
		isPanjat = true;
		temp = BGTiang.transform.position;
		temp.y -= 4 ;
		chara.SetTrigger ("panjat");

	}

	public void Jatuh(){
		isPanjat = false;
		isJatuh = true;
		temp = BGTiang.transform.position;
		temp.y = -2 ;

	}
}
