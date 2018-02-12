using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushingForce : MonoBehaviour {

    public float forceMagnitude;
    public bool deleteThisOnHit = false;

    float collisionAngle;

    //If this object is colliding with something
    void OnTriggerEnter2D(Collider2D other)
    {
        //If that object has the PhysicsObject tag
        if (other.gameObject.CompareTag("PhysicsObject"))
        { 
            Vector2 delta = other.gameObject.transform.position - this.gameObject.transform.position;
            delta.Normalize();
            //Set the other object's velocity equal to the force of this object and the angle between them
            other.attachedRigidbody.AddForce(delta * forceMagnitude);
            if (deleteThisOnHit)
            {
                Destroy(gameObject);
            }
        }
    }
}
