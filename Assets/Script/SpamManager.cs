using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamManager : MonoBehaviour {
    public GameObject chara;
    public float speedplayer;
    public float speednpc;
    public float delay;
    public bool isPlay = false;
    public bool isOver = false;
    public bool isWin = false;
    public bool isLose = false;
    private float time = 0;
    private CanvasManager canvasmgr;

    void Start()
    {
        canvasmgr = GameObject.Find("Canvases").GetComponent<CanvasManager>();

    }
    // Update is called once per frame
    void Update () {
        time += Time.deltaTime;
        if (time >= delay && isPlay && !isOver) {
            time = 0;
            NPCMove();
        }
        if (chara.transform.position.x >= 490)
        {
            isLose = true;
            isPlay = false;
            isOver = true;
            canvasmgr.GameOver();
        }

        else if (chara.transform.position.x <= 430)
        {
            isWin = true;
            isPlay = false;
            isOver = true;
            canvasmgr.GameOver();

        }
	}

    public void Spam() {
        if(isPlay && !isOver)
        chara.transform.Translate(-speedplayer, 0, 0);

    }

    void NPCMove() {
        chara.transform.Translate(speednpc,0, 0);

    }
}
