﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatManager : MonoBehaviour {

    public float speed;

    private CalcSystemManager calc;
    private ScoreManager score;

	// Use this for initialization
	void Start () {
        var canvasScale = GameObject.Find("CanvasGame").transform.localScale;
        Vector3 tr;
        if( transform.position.x < 0 ){
            //左に生成されたので右に進む
            tr = transform.right.normalized;
        }
        else {
            tr = transform.right.normalized * -1;
        }

        var calcSystem = GameObject.Find("CalcSystem");
        calc = calcSystem.GetComponent<CalcSystemManager>();

        var scoreManager = GameObject.Find("ScoreManager");
        score = scoreManager.GetComponent<ScoreManager>();

        GetComponent<Rigidbody2D>().velocity = tr * speed * canvasScale.x;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("collision enter");
        if (collision.gameObject.tag == "Bullet")
        {
            score.Add(20);
            calc.AddNum(0);
            //Debug.Log("Destroy");
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "Trap"){
            Destroy(this.gameObject);
        }
    }


}
