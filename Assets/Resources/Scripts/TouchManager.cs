using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour {
    public GameObject touchCollider;

    GameObject[] touches;
    const int touchNum = 5; //認識する指の数

	// Use this for initialization
	void Start () {
        touches = new GameObject[touchNum];

        for (int i=0; i < touchNum; i++) {
            touches[i] = Instantiate(touchCollider,transform);
            touches[i].SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
        Touch();
    }

    void Touch () {
        // タッチしていなければ何もしない
        if (Input.touchCount <= 0) return;
        foreach (Touch touch in Input.touches) {
            var id = touch.fingerId;
            var pos = Camera.main.ScreenToWorldPoint(touch.position);
            switch (touch.phase) {
                case TouchPhase.Began:
                    touches[id].SetActive(true);
                    touches[id].transform.position = pos;
                    break;
                case TouchPhase.Moved:
                    touches[id].transform.position = pos;
                    break;
                case TouchPhase.Ended:
                    touches[id].SetActive(false);
                    break;
                case TouchPhase.Canceled:
                    touches[id].SetActive(false);
                    break;
            }
        }
    }
}
