using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersControllerManager : MonoBehaviour {

    public GameObject invaders;
    private InvadersManager invadersManager;

	// Use this for initialization
	void Start () {
        invadersManager = invaders.GetComponent<InvadersManager>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Invader")
        {
            invadersManager.downDetect();
        }
    }
}
