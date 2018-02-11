using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursuing : MonoBehaviour {

    public float speed;

    private Vector2 playerPos;
    private Vector2 thisPos;
    private Vector2 endPos;
    private Vector2 targetPos;

    void Start()
    {

        playerPos = GameObject.Find("Player").transform.position;
        thisPos = this.gameObject.transform.position;
        endPos = GameObject.Find("EndOfTheWorld").transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (thisPos.x > playerPos.x)
            targetPos = playerPos;
        else
            targetPos = endPos;
        
        Vector2 delta = targetPos - thisPos;
        delta.Normalize();
        this.gameObject.transform.Translate(delta * speed * Time.deltaTime);
        playerPos = GameObject.Find("Player").transform.position;
        thisPos = this.gameObject.transform.position;
    }
}
