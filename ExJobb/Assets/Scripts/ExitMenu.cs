using UnityEngine;
using System.Collections;

public class ExitMenu : MonoBehaviour {

    public GameObject exitPrompt;
    
    public void ExitGame()
    {
        Application.Quit();
    }

    public void Return()
    {
        exitPrompt.GetComponent<Canvas>().enabled = false;
    }
}
