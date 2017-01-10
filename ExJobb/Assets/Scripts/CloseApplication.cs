using UnityEngine;
using System.Collections;

public class CloseApplication : MonoBehaviour {

    public GameObject exitPrompt;

    void Start()
    {
        exitPrompt.GetComponent<Canvas>().enabled = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            exitPrompt.GetComponent<Canvas>().enabled = true;
        }

    }

    public void ExitPrompt()
    {
        exitPrompt.GetComponent<Canvas>().enabled = true;
        //Application.Quit();
    }
}
