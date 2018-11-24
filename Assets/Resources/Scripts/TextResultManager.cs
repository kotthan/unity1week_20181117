using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextResultManager : MonoBehaviour {
    
    public float lifetime = 1;

    private Text text;

	// Use this for initialization
	void Awake () {
        text = this.gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetActive(int num = 10)
    {
        this.gameObject.SetActive(true);
        Debug.Log(text.text);
        text.text = "= " + num;
        Invoke("SetDisactive", lifetime);
    }

    public void SetDisactive()
    {
        this.gameObject.SetActive(false);
    }
}
