﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcSystemManager : MonoBehaviour {

    public GameObject textCalc;
    public GameObject scoreManagerObj;
    public GameObject lifeManagerObj;
    public GameObject invadersObj;

    private Text formula;
    private int result = 0;
    private ScoreManager score;
    private LifeManager life;
    private InvadersManager invaders;

	// Use this for initialization
	void Start () {
        formula = textCalc.GetComponent<Text>();
        CalcClear();
        score = scoreManagerObj.GetComponent<ScoreManager>();
        life = lifeManagerObj.GetComponent<LifeManager>();
        invaders = invadersObj.GetComponent<InvadersManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddNum ( int num ){
        if (result >= 10){
            CalcClear();
        }
        else if (result != 0){
            formula.text += " + ";
        }
        formula.text += num;
        if( num == 0 ){
            //UFO
            result = 10;
        }
        else{
            result += num;
        }
        Debug.Log("+ " + num + "= " + result );
        if( result == 10 ){
            Equal10();
        }
        else if( result > 10 ){
            Over10();
        }
    }
    void Equal10 () {
        formula.text += " = 10";
        score.Add(10);
        invaders.DestroyList();
    }

    void Over10 () {
        formula.text += " = " + result;
        life.Dead();
        invaders.RevivalList();
    }

    void CalcClear() {
        result = 0;
        formula.text = "";
    }
}