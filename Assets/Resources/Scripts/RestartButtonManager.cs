using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButtonManager : MonoBehaviour {

    public GameObject gameManager;
    private bool CanRestart = false;
    private bool ChangeFlg = false;
    private bool usingButtons = false;


	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update () {
        if (GameObject.Find("RankingSceneManager") == true ) {
            ChangeFlg = true;
        } else if ((GameObject.Find("RankingSceneManager") == false) && (ChangeFlg == true)) {
            CanRestart = true;
        }

        if ((Input.anyKey) && (CanRestart == true))
        {
            gameManager.GetComponent<GameManager>().Restart();
        }
    }
}
