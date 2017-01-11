using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

    public Click click;
    public GameObject endGameCanvas;

	// Use this for initialization
	void Awake()
    {
        endGameCanvas.GetComponent<Canvas>().enabled = false;
	
	}
	
	// Update is called once per frame
	void Update()
    {
        if(click.mEndGame == true)
        {
            endGameCanvas.GetComponent<Canvas>().enabled = true;
        }
	
	}

    public void ExitGame()
    {
        Application.Quit();
    }
}
