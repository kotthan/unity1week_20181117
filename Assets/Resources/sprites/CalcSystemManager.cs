using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcSystemManager : MonoBehaviour {

    public GameObject textCalc;

    private int result = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void GetNum ( int num ){
        textCalc.GetComponent<Text>().text += " + " + num;

    }

    void Over10 () {
        
    }
}
