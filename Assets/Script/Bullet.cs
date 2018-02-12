using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private static List<Bullet> allBullets;
    private Vector2 dir;
    public float speed;
    private float angle;

	// Use this for initialization
	void Start () {
        allBullets = new List<Bullet>();
	}

    void Awake()
    {
        //allBullets.Add(this);
        angle = this.GetComponentInParent<Transform>().rotation.eulerAngles.z;
        this.setDirection(this.GetComponentInParent<Transform>().rotation.eulerAngles);
    }

    // Update is called once per frame
    void Update () {

        this.transform.Translate(Vector2.left * Time.deltaTime * speed);
    }

    public void setDirection(Vector3 direction)
    {
        dir = direction;
        this.transform.rotation = Quaternion.Euler(0, 0, direction.z);
    }


}
