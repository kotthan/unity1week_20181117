using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatControllerManager : MonoBehaviour {

    public float minInterval;
    public float maxInterval;

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
            SetTimer();
        }
	}
}
