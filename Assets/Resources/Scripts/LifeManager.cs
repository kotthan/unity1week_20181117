using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour {

    public GameObject lifePrefab;
    public GameObject lifeText;
    public int maxLife;
    public Vector2 basePos;
    public float dist;
    public GameObject playerObj;
    private PlayerManager player;
    public GameObject gamaManager;

    private int life;
    private List<GameObject> lifeIcons;
    private string key = "life";

	// Use this for initialization
    void Start () {
        player = playerObj.GetComponent<PlayerManager>();
        life = PlayerPrefs.GetInt(key, maxLife);
        PlayerPrefs.SetInt(key, maxLife);
        Debug.Log("Life load" + life);
        lifeText.GetComponent<Text>().text = life.ToString();
        lifeIcons = new List<GameObject>{};
        for (int i = 0; i < life - 1; i++ ){
            var pos = new Vector3(dist * i + basePos.x, basePos.y);
            var q = new Quaternion();
            var icon = Instantiate(lifePrefab,pos,q);
            lifeIcons.Add(icon);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int Dead(){
        life -= 1;
        lifeText.GetComponent<Text>().text = life.ToString();
        if (life <= 0) {
            Destroy(playerObj);
            gamaManager.GetComponent<GameManager>().GameOver();
        }
        else {
            var icon = lifeIcons[lifeIcons.Count - 1];
            lifeIcons.Remove(icon);
            icon.GetComponent<LifeIconMagager>().Destroy();
            player.Damage();
        }
        return life;
    }

    public void Save(){
        Debug.Log("Life save"+life);
        PlayerPrefs.SetInt(key, life);
    }
}
