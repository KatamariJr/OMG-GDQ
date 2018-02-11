using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseCondition : MonoBehaviour {

    CanvasGroup loseCanvas;
    Scrolling s;
    public float initX, initY;

	// Use this for initialization
	void Start () {
        loseCanvas = GameObject.Find("LoseCanvas").GetComponent<CanvasGroup>();
        loseCanvas.alpha = 0;
        loseCanvas.interactable = false;
        s = GameObject.Find("World").GetComponent<Scrolling>();
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.x < -8f)
        {
            loseGame();
        }
	}

    public void loseGame()
    {
        loseCanvas.alpha = 1;
        loseCanvas.interactable = true;
        
    }//insufficient postage

    public void resetGame()
    {
        loseCanvas.alpha = 0;
        loseCanvas.interactable = false;
        s.init();
        resetPlayer();
    }

    public void resetPlayer()
    {
        this.transform.position = new Vector3(initX, initY, 0);
        this.GetComponent<Rigidbody2D>().velocity =new Vector2(0f, 0f);
        
    }
}
