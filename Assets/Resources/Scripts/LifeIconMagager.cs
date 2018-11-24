using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeIconMagager : MonoBehaviour {

    public float brinkTime;

    private Animator animator;
    private float timer = 0;

	// Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void Destroy()
    {
        animator.SetBool("brink",true);
        Destroy(this.gameObject, brinkTime);
    }
}
