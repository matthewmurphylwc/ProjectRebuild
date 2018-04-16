using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public int health;
    public Image Three_Hearts;
    public Image Two_Hearts;
    public Image One_Heart;
    public float lastHit;




    // Use this for initialization
    void Start () {
        health = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if(health == 3)
        {
            Three_Hearts.enabled = true;
            Two_Hearts.enabled = false;
            One_Heart.enabled = false;
        }
        if(health == 2)
        {
            Three_Hearts.enabled = false;
            Two_Hearts.enabled = true;
            One_Heart.enabled = false;
        }
        if (health == 1)
        {
            Three_Hearts.enabled = false;
            Two_Hearts.enabled = false;
            One_Heart.enabled = true;
        }
        if(health != 3 && (Time.deltaTime - lastHit >= 10))
        {
            health = health + 1;
        }
    }


    private void FixedUpdate()
    {
        //after character is hit
        lastHit = Time.deltaTime;
    }
}
