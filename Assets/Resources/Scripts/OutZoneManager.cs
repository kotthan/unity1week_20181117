using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutZoneManager : MonoBehaviour {

    public GameObject player;
    public GameObject gameManager;
    //public GameObject playerManager;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //衝突処理
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Invader")
        {
            gameManager.GetComponent<GameManager>().GameOver();
            DestroyPlayer();

        }
    }

    //プレイヤーオブジェクト削除処理
    public void DestroyPlayer() {
        Destroy(player.gameObject);
    }

}
