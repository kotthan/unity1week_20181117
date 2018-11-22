using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderManager : MonoBehaviour {

    public float[] ratio;
    private int value;
    CalcSystemManager calc;
    ScoreManager score;

	// Use this for initialization
	void Start () {
        SetValue();
        GetComponent<TextMesh>().text = value.ToString();
        var calcSystem = GameObject.Find("CalcSystem");
        calc = calcSystem.GetComponent<CalcSystemManager>();

        var scoreManager = GameObject.Find("ScoreManager");
        score = scoreManager.GetComponent<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("collision enter");
        if (collision.gameObject.tag == "Bullet")
        {
            //Debug.Log("Destroy");
            var parent = transform.parent.gameObject;
            Debug.Log(parent);
            score.Add(value);
            parent.GetComponent<InvadersManager>().AddDestroyList(gameObject);
            calc.AddNum(value);
        }
    }

    void SetValue(){
        float sum=0;
        foreach ( float r in ratio ){
            sum += r;
        }
        var randNum = Random.Range(0,sum);
        sum = 0;
        for (int i = 0; i < ratio.Length; i++ ){
            sum += ratio[i];
            if( randNum < sum ){
                value = i + 1;
                break;
            }
        }
    }
}
