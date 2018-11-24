using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBackManager : MonoBehaviour {

    private SpriteRenderer sprite;

	// Use this for initialization
	void Start () {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        Destroy(this.gameObject, 1);
	}
	
	// Update is called once per frame
	void Update () {
        var c = sprite.color;
        var alpha = c.a - Time.deltaTime / 2;
        Debug.Log("alpha:" + alpha);
        sprite.color = new Color(c.r, c.g, c.b, alpha);
	}
}
