using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject textGameOver;         //「ゲームオーバー」テキスト
    public GameObject textGameClear;         //「ゲームオーバー」テキスト
    public GameObject ButtonsGameover;      //操作ボタン
    public GameObject InvadersController;   //インベーダーコントローラ
    public GameObject ScoreManager;
    public GameObject TextCalculationVariable;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameClear(){
        textGameClear.SetActive(true);
    }

    //ゲームオーバー処理
    public void GameOver() {
        var scoreManager = ScoreManager.GetComponent<ScoreManager>();
        scoreManager.CheckHiscore();
        textGameOver.SetActive(true);
        ButtonsGameover.SetActive(true);
        InvadersController.SetActive(false);
        TextCalculationVariable.SetActive(false);

        // Type == Number の場合
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(scoreManager.score);

    }

    //ボタン処理
    public void Restart() {         // 現在のScene名を取得する         Scene loadScene = SceneManager.GetActiveScene();         // Sceneの読み直し         SceneManager.LoadScene(loadScene.name);     } 
    public void InRestart(){        Invoke ("Restart", 0.1f);   } 

    public void LoadTitle() {       SceneManager.LoadScene ("TitleScene");  }   public void InLoadTitle() {         Invoke ("LoadTitle", 0.1f);     } 
}
