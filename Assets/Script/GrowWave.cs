using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowWave : MonoBehaviour
{
    public float sizeScaling;

    void FixedUpdate()
    {
        this.gameObject.transform.localScale = this.gameObject.transform.localScale * sizeScaling;

        CircleCollider2D thisCollider = this.gameObject.GetComponent<CircleCollider2D>();
        thisCollider.radius = thisCollider.radius * sizeScaling;

        PushingForce thisForce = this.gameObject.GetComponent<PushingForce>();
        thisForce.forceMagnitude = thisForce.forceMagnitude * sizeScaling;
    }	
}
