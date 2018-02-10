using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushingForce : MonoBehaviour {

    public float forceMagnitude;

    float collisionAngle;

    //If this object is colliding with something
    void OnTriggerEnter2D(Collider2D other)
    {
        //If that object has the PhysicsObject tag
        if (other.gameObject.CompareTag("PhysicsObject"))
        {
            //Calculated the angle between this object's center and the other object's center
            float deltaX = this.gameObject.transform.position.x - other.gameObject.transform.position.x;
            float deltaY = this.gameObject.transform.position.y - other.gameObject.transform.position.y;
            float collisionAngle = Mathf.Atan(deltaY / deltaX);
            collisionAngle = collisionAngle * 180 / Mathf.PI;
            if (deltaX < 0)
                collisionAngle += 180;
            Vector2 forceDirection = new Vector2(Mathf.Cos(collisionAngle), Mathf.Sin(collisionAngle));
            forceDirection.Normalize();
            //Set the other object's velocity equal to the force of this object and the angle between them
            other.attachedRigidbody.AddForce(forceDirection * forceMagnitude);
        }
    }

            Vector2 delta = other.gameObject.transform.position - this.gameObject.transform.position;
            delta.Normalize();
            //Set the other object's velocity equal to the force of this object and the angle between them
            other.attachedRigidbody.AddForce(delta * forceMagnitude);
        }
    }
}
