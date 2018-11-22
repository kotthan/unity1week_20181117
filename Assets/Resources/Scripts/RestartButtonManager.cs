using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButtonManager : MonoBehaviour {

    public GameObject gameManager;

    private bool usingButtons = false;


	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update () {

        if (!GameObject.Find("RankingSceneManager")) {
            if (Input.anyKey) {
                gameManager.GetComponent<GameManager>().Restart();
            }
        }
		
	}
}
