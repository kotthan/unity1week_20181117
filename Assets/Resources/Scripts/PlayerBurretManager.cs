using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBurretManager : MonoBehaviour
{

    //[SerializeField] //ここ削除①
    private GameObject _burret; //弾のプレファブ。inspectorで指定する

    private float _shotDelay = 0.1f; //弾を打つ間隔

    private Transform _tf;

    //private BurretPool _pool; //ここ追加①


    void Start()
    {
        _tf = this.transform;
        // ここ追加②。プールへの参照を保存しておく
        //_pool = GameObject.Find("pool").GetComponent<BurretPool>();
        // 弾を打つコルーチンを呼び出す
        StartCoroutine(ShotBurret());
    }

    IEnumerator ShotBurret()
    {
        while (true)
        {
            // 弾をプレイヤーと同じ位置/角度で作成
            Shot();

            // shotDelay秒待つ
            yield return new WaitForSeconds(_shotDelay);
        }
    }

    private void Shot()
    {
        // ここ追加③。プールから弾をもらう
        //var burret = _pool.GetBurret();
        //burret.transform.localPosition = _tf.position;

        //ここ削除②。弾をプレイヤーと同じ位置/角度で作成
        Instantiate (_burret, _tf.position, _tf.rotation);
    }

}