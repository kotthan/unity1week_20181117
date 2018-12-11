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

	// Use this for initialization
	void Start () {
        defPos = transform.position;
        Debug.Log("def:"+defPos.ToString());
        playerMng = playerObj.GetComponent<PlayerManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
#if false
    private void OnMouseDown()
    {
        startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public void OnMouseDrag()
    {
        var nowPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var pos = nowPos - startPos;
        if( pos.x > moveMax )
        {
            pos = new Vector3(moveMax, pos.y, pos.z);
        }
        else if(pos.x < -moveMax)
        {
            pos = new Vector3(-moveMax, pos.y, pos.z);
        }
        transform.position = new Vector3(defPos.x+pos.x, defPos.y, defPos.z);

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

    private void OnMouseUp()
    {
        Debug.Log("mouse Release");
        playerMng.ReleaseMoveButton();
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
