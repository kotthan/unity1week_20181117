using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    private Rigidbody2D rbody;          //プレイヤー制御用
    private const float MOVE_SPEED = 3; //移動速度固定
    private float moveSpeed;            //移動速度

    public enum MOVE_DIR                //移動方向定義
    {
        STOP,
        LEFT,
        RIGHT,
    };

    private MOVE_DIR moveDirection = MOVE_DIR.STOP; //移動方向

	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
