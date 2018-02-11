using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalInputListener : MonoBehaviour
{
    bool isPaused;
    bool isStarted;
    CanvasGroup pauseCanvas;
    CanvasGroup menuCanvas;

    // Use this for initialization
    void Start()
    {
        
        pauseCanvas = GameObject.Find("PauseCanvas").GetComponent<CanvasGroup>();
        menuCanvas = GameObject.Find("MenuCanvas").GetComponent<CanvasGroup>();
        Time.timeScale = 0;
        pauseCanvas.interactable = false;
        pauseCanvas.alpha = 0;
        isPaused = true;
        isStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            togglePause();
        }
    }

    public void startGame(){
        menuCanvas.interactable = false;
        menuCanvas.alpha = 0;
        unpauseGame();
        isStarted = true;
    }

    public void togglePause()
    {
        if (isPaused)
            unpauseGame();
        else
            pauseGame();
    }

    public void pauseGame()
    {
        //show pause canvas
        pauseCanvas.alpha = 1;
        pauseCanvas.interactable = true;
        //pause game
        Time.timeScale = 0;
        isPaused = true;
    }

    public void unpauseGame()
    {
        //hide pause canvas
        pauseCanvas.alpha = 0;
        pauseCanvas.interactable = false;
        //unpause game
        Time.timeScale = 1;
        isPaused = false;
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