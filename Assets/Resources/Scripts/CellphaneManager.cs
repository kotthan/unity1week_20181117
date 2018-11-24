using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellphaneManager : MonoBehaviour {

    public Color color;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        var sprite = col.gameObject.GetComponent<SpriteRenderer>();
        if (sprite != null) {
            sprite.color = color;
            return;
        }

        var textMexh = col.gameObject.GetComponent<TextMesh>();
        if( textMexh != null ){
            textMexh.color = color;
            return;
        }
    }
}
