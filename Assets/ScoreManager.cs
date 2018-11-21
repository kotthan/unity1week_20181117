using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public GameObject textScore;
    private Text text;
    private int score;

	// Use this for initialization
	void Start () {
        score = 0;
        text = textScore.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void Add(int num){
        score += num;
        text.text = string.Format("{0:00000}", score);
    }

}
