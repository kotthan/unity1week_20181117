using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeverNobManager : MonoBehaviour {

    private Vector3 defPos;

	// Use this for initialization
	void Start () {
        defPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseDrag()
    {
        var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(pos.x, defPos.y, defPos.z);
    }
}
