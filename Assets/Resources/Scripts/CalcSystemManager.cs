using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcSystemManager : MonoBehaviour {

    public GameObject textCalc;
    public GameObject scoreManagerObj;
    public GameObject lifeManagerObj;
    public GameObject invadersObj;
    public GameObject textEqual10Obj;
    public GameObject textOver10Obj;

    private Text formula;
    private int result = 0;
    private ScoreManager score;
    private LifeManager life;
    private InvadersManager invaders;
    private TextResultManager textEqual10;
    private TextResultManager textOver10;

	// Use this for initialization
	void Start () {
        formula = textCalc.GetComponent<Text>();
        score = scoreManagerObj.GetComponent<ScoreManager>();
        life = lifeManagerObj.GetComponent<LifeManager>();
        invaders = invadersObj.GetComponent<InvadersManager>();
        textEqual10 = textEqual10Obj.GetComponent<TextResultManager>();
        textOver10 = textOver10Obj.GetComponent<TextResultManager>();
        CalcClear();
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
        if( num == 0 ){
            //UFO
            result = 10;
            formula.text += "!";
        }
        else{
            formula.text += num;
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
        textCalc.SetActive(false);
        textEqual10.SetActive();
        score.Add(10);
        invaders.DestroyList();
    }

    void Over10 () {
        textCalc.SetActive(false);
        textOver10.SetActive(result);
        var left = life.Dead();
        if (left != 0) {
            //invaders.RevivalList();
            invaders.DestroyList();
        }
    }

    void CalcClear() {
        result = 0;
        formula.text = "";
        textCalc.SetActive(true);
        textOver10.SetDisactive();
        textEqual10.SetDisactive();
    }
}
