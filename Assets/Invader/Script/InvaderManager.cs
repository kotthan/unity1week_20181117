﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void OnTriggerExitD(Collider2D collision)
    {
        Debug.Log("collision exit");
        if (collision.gameObject.tag == "Invader")
        {
        }
    }
}
