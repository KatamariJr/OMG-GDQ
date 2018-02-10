using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveControl : MonoBehaviour
{
    Vector3 start_wave;
    Vector3 end_wave;
    object wave_sprite;

	void Update ()
    {
        if (Input.GetButtonDown("LeftClick"))
        {
            Debug.Log(Input.mousePosition);
            start_wave = Input.mousePosition;
        }

        if (Input.GetButtonUp("LeftClick"))
        {
            Debug.Log(Input.mousePosition);
            end_wave = Input.mousePosition;
            CreateWave(start_wave, end_wave);
        }
    }

    void CreateWave(Vector3 start, Vector3 end)
    {
        Instantiate(wave_sprite, start_wave, Quaternion.identity);
    }
}
