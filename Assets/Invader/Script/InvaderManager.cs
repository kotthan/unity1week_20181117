using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderManager : MonoBehaviour {

    private int value;
    CalcSystemManager calc;

	// Use this for initialization
	void Start () {
        value = Random.Range(1, 9);
        GetComponent<TextMesh>().text = value.ToString();
        var calcSystem = GameObject.Find("CalcSystem");
        calc = calcSystem.GetComponent<CalcSystemManager>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("collision enter");
        if (collision.gameObject.tag == "Bullet")
        {
            calc.AddNum(value);
            //Debug.Log("Destroy");
            Destroy(this.gameObject);
        }
    }
}
