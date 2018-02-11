using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static : MonoBehaviour
{
	 public float scrollSpeed;

    // Update is called once per frame
    void FixedUpdate()
    {
        this.gameObject.transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
    }
}
