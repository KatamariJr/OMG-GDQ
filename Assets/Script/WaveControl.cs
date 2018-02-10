using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveControl : MonoBehaviour
{
    Vector3 start_wave;
    Vector3 end_wave;
    public Object wave_sprite;

	void Update ()
    {
        if (Input.GetButtonDown("LeftClick"))
        {
            Debug.Log(Input.mousePosition);
            start_wave = Input.mousePosition;
            start_wave = Camera.main.ScreenToWorldPoint(start_wave);
        }

        if (Input.GetButtonUp("LeftClick"))
        {
            Debug.Log(Input.mousePosition);
            end_wave = Input.mousePosition;
            end_wave = Camera.main.ScreenToWorldPoint(end_wave);
            CreateWave(start_wave, end_wave);

        }
    }

    void CreateWave(Vector3 start, Vector3 end)
    {
        start.z = 0;
        end.z = 0;
        Instantiate(wave_sprite, start, Quaternion.identity);
    }
}
