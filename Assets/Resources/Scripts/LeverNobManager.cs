using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeverNobManager : MonoBehaviour {

    public float moveThreshold;
    public float moveMax;
    public GameObject playerObj;
    private PlayerManager playerMng;

    private Vector3 defPos;
    private Vector3 startPos;
    private int fingerId = -1;

	// Use this for initialization
	void Start () {
        defPos = transform.position;
        Debug.Log("def:"+defPos.ToString());
        playerMng = playerObj.GetComponent<PlayerManager>();
	}

    // Update is called once per frame
    void Update () {

    }

#if true
    void CheckTouch()
    {
        if (Input.touchCount <= 0) { return; }
        if (fingerId != -1 ) { return; }
        foreach (Touch touch in Input.touches)
        {
            if ( touch.phase == TouchPhase.Began)
            {
                fingerId = touch.fingerId;
                Debug.Log("finger" + fingerId);
            }
        }
    }

    private void OnMouseDown()
    {
        startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        CheckTouch();
    }

    public void OnMouseDrag()
    {
        Vector3 newPos = Vector3.zero;
        if (Input.touchCount > 0)
        {
            if (fingerId == -1) { return; }
            var isTouch = false;
            foreach (Touch touch in Input.touches)
            {
                if (fingerId == touch.fingerId)
                {
                    isTouch = true;
                    newPos = Camera.main.ScreenToWorldPoint(touch.position);
                    break;
                }
            }
            if (isTouch == false)
            {
                fingerId = -1;
                return;
            }
        }
        else
        {
            newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        var pos = newPos - startPos;
        if( pos.x > moveMax )
        {
            pos = new Vector3(moveMax, pos.y, pos.z);
        }
        else if(pos.x < -moveMax)
        {
            pos = new Vector3(-moveMax, pos.y, pos.z);
        }
        transform.position = new Vector3(defPos.x+pos.x, defPos.y, defPos.z);

        //Debug.Log("pos.x=" + pos.x + " def" + defPos.x);
        if (pos.x > moveThreshold)
        {
            playerMng.PushRightButton();
        }
        else if (pos.x < -moveThreshold)
        {
            playerMng.PushLeftButton();
        }
        else
        {
            playerMng.ReleaseMoveButton();
        }
    }

    private void OnMouseUp()
    {
        Debug.Log("mouse Release");
        playerMng.ReleaseMoveButton();
        fingerId = -1;
    }
#else

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var obj = collision.gameObject;
        if (obj.tag == "Touch")
        {
            startPos = obj.transform.position;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        var obj = collision.gameObject;
        if (obj.tag == "Touch")
        {
            TouchMove(obj.transform.position);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        var obj = collision.gameObject;
        if (obj.tag == "Touch")
        {
            playerMng.ReleaseMoveButton();
        }
    }

    private void TouchMove(Vector3 newPos)
    {
        var pos = newPos - startPos;
        if (pos.x > moveMax)
        {
            pos = new Vector3(moveMax, pos.y, pos.z);
        }
        else if (pos.x < -moveMax)
        {
            pos = new Vector3(-moveMax, pos.y, pos.z);
        }
        transform.position = new Vector3(defPos.x + pos.x, defPos.y, defPos.z);

        Debug.Log("pos.x=" + pos.x + " def" + defPos.x);
        if (pos.x > moveThreshold)
        {
            playerMng.PushRightButton();
        }
        else if (pos.x < -moveThreshold)
        {
            playerMng.PushLeftButton();
        }
        else
        {
            playerMng.ReleaseMoveButton();
        }
    }
#endif

}
