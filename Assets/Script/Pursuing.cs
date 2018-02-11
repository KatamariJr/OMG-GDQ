using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursuing : MonoBehaviour {

    public float speed;

    private Vector2 playerPos;
    private Vector2 thisPos;

    void Start()
    {

        playerPos = GameObject.Find("Player").transform.position;
        thisPos = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (thisPos.x > playerPos.x)
        {
            Vector2 delta = playerPos - thisPos;
            delta.Normalize();
            this.gameObject.transform.Translate(delta * speed * Time.deltaTime);
            playerPos = GameObject.Find("Player").transform.position;
            thisPos = this.gameObject.transform.position;
        }  
        else
        {
            this.gameObject.transform.Translate(Vector2.left * speed * Time.deltaTime);
            playerPos = GameObject.Find("Player").transform.position;
            thisPos = this.gameObject.transform.position;
        }
    }
}
