using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcSystemManager : MonoBehaviour {

    public GameObject textCalc;

    private Text formula;
    private int result = 0;

	// Use this for initialization
	void Start () {
        formula = textCalc.GetComponent<Text>();
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
        formula.text += num;
        result += num;
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
    }

    void Over10 () {
        formula.text += " = " + result;
    }

    void CalcClear() {
        result = 0;
        formula.text = "";
    }
}
