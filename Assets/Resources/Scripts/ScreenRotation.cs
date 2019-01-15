using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {

        // 縦
        Screen.autorotateToPortrait = false;
        // 左
        Screen.autorotateToLandscapeLeft = true;
        // 右
        Screen.autorotateToLandscapeRight = true;
        // 上下反転
        Screen.autorotateToPortraitUpsideDown = false;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
