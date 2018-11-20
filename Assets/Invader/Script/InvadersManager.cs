using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersManager : MonoBehaviour
{

    public float interval;      //移動間隔
    public Vector2 move;        //移動量
    public Vector2 distance;    //invader間の距離
    public int col;        //初期生成列数
    public int row;
    public GameObject invaderPrefab;

    private float timer = 0;    //移動からの経過時間
    private bool downFlg = false;
    private bool moveRight = true;

    // Use this for initialization
    void Start()
    {
        Vector3 pos = new Vector3( -400f, 700f );
        for (int i = 0; i < row; i++ ){
            pos = new Vector3(-400f, pos.y);
            for (int j = 0; j < col; j++ ){
                var invader = Instantiate(invaderPrefab, transform);
                invader.transform.localPosition = pos;
                pos = new Vector3(pos.x + distance.x, pos.y);
            }
            pos = new Vector3(pos.x, pos.y - distance.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //経過時間を足す
        timer += Time.deltaTime;
        if (timer > interval)
        {
            Move();     //移動
            timer = 0;  //タイマーのリセット
        }
    }

    void Move()
    {
        if (downFlg == true)
        {
            Down();
            moveRight = !moveRight;
            downFlg = false;
        }
        else if (moveRight == true)
        {
            Right();
        }
        else {
            Left();
        }
    }

    void Down()
    {
        //下に１段下がる
        Debug.Log("Down");
        var pos = transform.position;
        transform.position = new Vector2(pos.x, pos.y - move.y);
    }

    void Right()
    {
        Debug.Log("Right");
        var pos = transform.position;
        transform.position = new Vector2(pos.x + move.x, pos.y);
    }

    void Left()
    {
        Debug.Log("Left");
        var pos = transform.position;
        transform.position = new Vector2(pos.x - move.x, pos.y);
    }

    public void downDetect(){
        downFlg = true;
    }
}
