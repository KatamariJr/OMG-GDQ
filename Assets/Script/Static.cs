using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static : MonoBehaviour
{

    // Update is called once per frame
    void FixedUpdate()
    {

        this.gameObject.transform.Translate(Vector3.left * GameObject.Find("World").GetComponent<Scrolling>().scrollSpeed * Time.deltaTime);
    }
}
