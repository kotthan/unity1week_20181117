using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderManager : MonoBehaviour {

    private int value;

	// Use this for initialization
	void Start () {
        value = Random.Range(1, 9);
        GetComponent<TextMesh>().text = value.ToString();
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
            Destroy(this.gameObject);
        }
    }
}
