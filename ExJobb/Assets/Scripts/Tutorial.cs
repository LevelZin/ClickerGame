using UnityEngine;
using System.Collections;

public class Tutorial : MonoBehaviour {

    public Click click;
    public GameObject tutorialCanvas;
    private bool tOnce = false;

    void Start()
    {
        Debug.Log("Tutorial Disabled 1 from tutorial script");
        tutorialCanvas.GetComponent<Canvas>().enabled = false;
    }

    void Update()
    {
        if (tOnce == false)
        {
            if (click.currentBr == 10)
            {
                tutorialCanvas.GetComponent<Canvas>().enabled = true;
                tOnce = true;
            }
        }
    }

    public void Accept()
    {
        Debug.Log("Tutorial Disabled 2 from tutorial script");
        StartCoroutine(WaitOnClose());
    }

    IEnumerator WaitOnClose()
    {
        yield return new WaitForSeconds(1);
        tutorialCanvas.GetComponent<Canvas>().enabled = false;

    }
}
