using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zap : MonoBehaviour {

    public float movementSpeed;
    public float gunRange;
    private float gunCharge;
    public GameObject bullet;

	// Use this for initialization
	void Start () {
        gunCharge = 0;
	}

    // Update is called once per frame

    void FixedUpdate()
    {
        this.gameObject.transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);

        //if player is within a range to be determined (2.5 tiles away?)
        Vector3 playerPos = GameObject.Find("Player").transform.position;

        Vector3 delta =  this.transform.position - playerPos;

        if ((playerPos - this.transform.position).magnitude < gunRange)
        {
            gunCharge += Time.deltaTime;
            float rotationAngle = Mathf.Atan(delta.y / delta.x);
            rotationAngle = rotationAngle * 180 / Mathf.PI;
            if (delta.x < 0)
                rotationAngle += 180;

            this.GetComponentInChildren<Transform>().GetChild(0).rotation = Quaternion.Euler(0, 0, rotationAngle);
            if (gunCharge > 0.5)
            {
                gunCharge = 0;

                Instantiate(bullet, this.transform.position, Quaternion.Euler(0, 0, rotationAngle));
                
            }
            

        }

        //trigger animation

        //spawn projectile prefab in direction of player
        


    }


}
