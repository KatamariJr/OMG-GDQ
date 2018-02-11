using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveControl : MonoBehaviour
{
    Vector3 startWave;
    Vector3 endWave;
    public GameObject waveSprite;
    public List<GameObject> activeWaves;
    public int speed;

    void Start()
    {
        activeWaves = new List<GameObject>();
    }

	void Update ()
    {
        if (Input.GetButtonDown("LeftClick"))
        {
            
            startWave = Input.mousePosition;
            startWave = Camera.main.ScreenToWorldPoint(startWave);
        }

        if (Input.GetButtonUp("LeftClick"))
        {
           
            endWave = Input.mousePosition;
            endWave = Camera.main.ScreenToWorldPoint(endWave);
            GameObject wave = CreateWave(startWave, endWave);
        }

        foreach(GameObject w in activeWaves)
        {
            w.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }


    //Checks for physics 
    void FixedUpdate()
    {

        foreach(GameObject w in activeWaves)
        {
            w.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }

    GameObject CreateWave(Vector3 start, Vector3 end)
    {
        start.z = 0;
        end.z = 0;
        float deltaX = end.x - start.x;
        float deltaY = end.y - start.y;
        //Vector2 deltaVector = new Vector2(deltaX, deltaY);
        //float rotationAngle = Vector2.SignedAngle(deltaVector, Vector2.right);
        float rotationAngle = Mathf.Atan(deltaY / deltaX);
        rotationAngle = rotationAngle * 180 / Mathf.PI;
        if (deltaX < 0)
               rotationAngle += 180;
        //float rotationAngle = Vector2.SignedAngle(start, end);
        Debug.Log(rotationAngle);
        GameObject wave = Instantiate(waveSprite, start, Quaternion.identity);
        wave.transform.Rotate(0,0,rotationAngle);
        activeWaves.Add(wave);
        return wave;
    }
}
