using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour {

    public float speed;
    public float scrollSpeed;
    public int upperBound;
    public int lowerBound;

    private int dir;
    private Vector2 thisPos;

    void Start()
    {
        thisPos = this.gameObject.transform.position;
        dir = Random.Range(0, 2);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (dir == 0)
        {
            this.gameObject.transform.Translate(((Vector2.left * scrollSpeed) + (Vector2.up * speed)/2) * Time.deltaTime);
            thisPos = this.gameObject.transform.position;
            if (thisPos.y > upperBound)
            {
                dir = 1;
            }
        }
        else if (dir == 1)
        {
            this.gameObject.transform.Translate(((Vector2.left * scrollSpeed) + (Vector2.down * speed)/2) * Time.deltaTime);
            thisPos = this.gameObject.transform.position;
            if (thisPos.y < lowerBound)
            {
                dir = 0;
            }
        }
    }

}
