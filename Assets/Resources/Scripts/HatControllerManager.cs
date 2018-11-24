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

    void SetTimer() {
        interval = Random.Range(minInterval, maxInterval);
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
        Vector3 pos;
        //左右どっち側に作るか
        if ( Random.Range(0, 2) == 0 ){
            pos = new Vector3(position.x,position.y);
        }
        else {
            pos = new Vector3(-position.x, position.y);
        }

        var q = new Quaternion();
        Instantiate(HatPrefab, pos, q);
        SetTimer();
    }
}
