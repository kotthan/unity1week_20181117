using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatControllerManager : MonoBehaviour {

    public float minInterval;
    public float maxInterval;
    public GameObject HatPrefab;
    public Vector2 position;

    private float interval;
    private float time;

    // Use this for initialization
    void Start () {
        SetTimer();
	}

    void SetTimer(int val=0) {
        if (val == 0) {
            interval = Random.Range(minInterval, maxInterval);
        }
        else {
            interval = (float)val;
        }
        time = 0;
    }
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if( time > interval)
        {
            Debug.Log("Hat!"+time);
            CreateHat();
        }
	}

    public void CreateHat(){

        var hat = GameObject.Find("Hat");
        if ( hat != null ) {
            //すでにあるので作らずに再度タイマーを設定
            SetTimer(5);
            return;
        }

        Vector3 pos;
        //左右どっち側に作るか
        if ( Random.Range(0, 2) == 0 ){
            pos = new Vector3(position.x,position.y);
        }
        else {
            pos = new Vector3(-position.x, position.y);
        }

        var q = new Quaternion();
        hat = Instantiate(HatPrefab, pos, q);
        hat.transform.SetParent(transform,false);
        hat.name = "Hat";
        SetTimer();
    }
}
