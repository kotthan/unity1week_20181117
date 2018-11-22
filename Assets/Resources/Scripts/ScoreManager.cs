﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public GameObject textScoreObj;
    public GameObject textHiscoreObj;
    private Text textScore;
    private Text textHiscore;
    private int score;
    private int hiscore;
    private string key = "Hiscore";

	// Use this for initialization
	void Start () {
        score = 0;
        textScore = textScoreObj.GetComponent<Text>();
        hiscore = PlayerPrefs.GetInt(key, 0);
        Debug.Log("hiscoe read" + hiscore);
        textHiscore = textHiscoreObj.GetComponent<Text>();
        textHiscore.text = string.Format("{0:00000}", hiscore);
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void Add(int num){
        score += num;
        textScore.text = string.Format("{0:00000}", score);
    }

    public void CheckHiscore(){
        if( hiscore < score ){
            hiscore = score;
            PlayerPrefs.SetInt(key, hiscore);
            Debug.Log("hiscoe up" + hiscore);
            textHiscore.text = string.Format("{0:00000}", hiscore);
        }
    }

}
