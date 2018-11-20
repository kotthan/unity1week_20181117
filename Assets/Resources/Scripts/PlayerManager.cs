using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    private Rigidbody2D rbody;          //プレイヤー制御用
    private const float MOVE_SPEED = 100; //移動速度固定
    private float moveSpeed;            //移動速度
    private bool usingButtons = false;  //ボタンを押しているか

    public enum MOVE_DIR                //移動方向定義
    {
        STOP,
        LEFT,
        RIGHT,
    };

    private MOVE_DIR moveDirection = MOVE_DIR.STOP; //移動方向

    private GameObject _burret;
    private float _shotDelay = 0.1f;
    private Transform _tf;

	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody2D>();
        _tf = this.transform;
        StartCoroutine(ShotBurret());
	}
	
	// Update is called once per frame
	void Update () {
        if (!usingButtons) {
            float x = Input.GetAxisRaw("Horizontal");
            if (x == 0) {
                moveDirection = MOVE_DIR.STOP;
            } else {
                if (x < 0) {
                    moveDirection = MOVE_DIR.LEFT;
                } else {
                    moveDirection = MOVE_DIR.RIGHT;
                }
            }
            if (Input.GetKeyDown("space")) {
                //スペースで行う処理
            }
        }
	}

    private void FixedUpdate()
    {
        //移動方向で処理を分岐
        switch(moveDirection) {
            case MOVE_DIR.STOP: // 停止
                moveSpeed = 0;
                break;
            case MOVE_DIR.LEFT: // 左に移動
                moveSpeed = MOVE_SPEED * -1;
                //transform.localScale = new Vector2(-1, 1);
                break;
            case MOVE_DIR.RIGHT: //右に移動
                moveSpeed = MOVE_SPEED;
                //transform.localScale = new Vector2(1, 1);
                break;
        }

        rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
    }

    public void PushLeftButton() {
        moveDirection = MOVE_DIR.LEFT;
        usingButtons = true;
    }

    public void PushRightButton() {
        moveDirection = MOVE_DIR.RIGHT;
        usingButtons = true;
    }

    public void ReleaseMoveButton() {
        moveDirection = MOVE_DIR.STOP;
        usingButtons = true;
    }

    IEnumerator ShotBurret() {
        while (true) {
            Shot();
            yield return new WaitForSeconds(_shotDelay);
        }
    }

    private void Shot () {
        Instantiate(_burret, _tf.position, _tf.rotation);
    }

}
