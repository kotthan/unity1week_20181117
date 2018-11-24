using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersManager : MonoBehaviour
{

    public float interval;      //移動間隔
    public Vector2 move;        //移動量
    public Vector2 distance;    //invader間の距離
    public Vector2 offset;      //初期配置オフセット
    public int col;             //初期生成列数
    public int row;
    public GameObject invaderPrefab;
    public GameObject gameManager;
    public GameObject hatController;

    private float timer = 0;    //移動からの経過時間
    private bool downFlg = false;
    private bool moveRight = true;
    List<GameObject> destroyInvaders = new List<GameObject> { };
    private int count;
    private HatControllerManager hat;

    // Use this for initialization
    void Start()
    {
        hat = hatController.GetComponent<HatControllerManager>();
        Vector3 pos = new Vector3( offset.x, offset.y );
        count = 0;
        for (int i = 0; i < row; i++ ){
            pos = new Vector3( offset.x, pos.y );
            for (int j = 0; j < col; j++ ){
                var invader = Instantiate(invaderPrefab, transform);
                invader.transform.localPosition = pos;
                pos = new Vector3(pos.x + distance.x, pos.y);
                count++;
            }
            pos = new Vector3(pos.x, pos.y - distance.y);
        }
        Debug.Log("All Invaders"+count);
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
        //Debug.Log("Down");
        var pos = transform.position;
        transform.position = new Vector2(pos.x, pos.y - move.y);
    }

    void Right()
    {
        //Debug.Log("Right");
        var pos = transform.position;
        transform.position = new Vector2(pos.x + move.x, pos.y);
    }

    void Left()
    {
        //Debug.Log("Left");
        var pos = transform.position;
        transform.position = new Vector2(pos.x - move.x, pos.y);
    }

    public void downDetect(){
        downFlg = true;
    }

    public void AddDestroyList (GameObject invader){
        invader.SetActive(false);
        count -= 1;
        if( count == 0 ){
            hat.CreateHat();
        }
        Debug.Log("invaders:" + count);
        destroyInvaders.Add(invader);
    }

    public void DestroyList(){
        var result = 0;
        foreach ( GameObject obj in destroyInvaders ){
            result += obj.GetComponent<InvaderManager>().GetValue();
            Destroy(obj);
        }
        destroyInvaders.Clear();
        if( count == 0 ){
            Debug.Log("result" + result);
            if (result == 10)
            {
                gameManager.GetComponent<GameManager>().GameClear(true);
            }
            else
            {
                gameManager.GetComponent<GameManager>().GameClear(false);
            }
        }
    }

    public void RevivalList(){
        foreach (GameObject obj in destroyInvaders)
        {
            obj.SetActive(true);
        }
        destroyInvaders.Clear();
    }
}
