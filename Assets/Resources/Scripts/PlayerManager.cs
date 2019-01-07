using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    private Rigidbody2D rbody;          //プレイヤー制御用
    private const float MOVE_SPEED = 300; //移動速度固定
    private float moveSpeed;            //移動速度
    private bool usingButtons = false;  //ボタンを押しているか
    public GameObject burret;
    private Transform tf;
    private GameObject bulletInstance;
    public GameObject gameManager;
    private Animator animator;
    public GameObject damageBack;
    private Transform canvasGame;

    public enum MOVE_DIR                //移動方向定義
    {
        STOP,
        LEFT,
        RIGHT,
    };

    private MOVE_DIR moveDirection = MOVE_DIR.STOP; //移動方向


	// Use this for initialization
	void Start () {
        canvasGame = GameObject.Find("CanvasGame").transform;
        animator = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody2D>();
        tf = this.transform;
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
                Shot();
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

        rbody.velocity = new Vector2(moveSpeed * canvasGame.localScale.x, rbody.velocity.y);
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

    public void Shot() {
        if (bulletInstance == null) {
            bulletInstance = Instantiate(burret, transform.parent, false);
            bulletInstance.transform.SetPositionAndRotation(tf.position, tf.rotation);
        }
    }


    //衝突処理
   /*
      private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Invader") {
            gameManager.GetComponent<GameManager>().GameOver();
            DestroyPlayer();
        }
    }
    */

    public void Damage(){
        animator.SetTrigger("brink");
        Instantiate(damageBack);
    }

    //プレイヤーオブジェクト削除処理
    public void DestroyPlayer() {
        Destroy(this.gameObject);
    }


}
