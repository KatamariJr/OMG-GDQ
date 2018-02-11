using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalInputListener : MonoBehaviour
{
    bool isPaused;
    CanvasGroup pauseCanvas;

    // Use this for initialization
    void Start()
    {
        isPaused = true;
        pauseCanvas = GameObject.Find("PauseCanvas").GetComponent<CanvasGroup>();


        togglePause();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            
            togglePause();
        }


    }

    public void togglePause()
    {
        if (isPaused)
        {
            //hide pause canvas
            pauseCanvas.alpha = 0;
            pauseCanvas.interactable = false;
            //unpause game
            Time.timeScale = 1;
        }
        else
        {
            //show pause canvas
            pauseCanvas.alpha = 1;
            pauseCanvas.interactable = true;
            //pause game
            Time.timeScale = 0;
        }
        isPaused = !isPaused;

    }

    public void exitGame()
    {
        #if UNITY_EDITOR
            // Application.Quit() does not work in the editor so
            // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

}