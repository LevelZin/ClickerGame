using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Click : MonoBehaviour {

    [SerializeField]
    private Text mBrDisplay;
    [SerializeField]
    private Text mBPC;
    
    public float currentBr = 0.0f;
    public float brPerClick = 1.0f;

    void Update()
    {
        mBrDisplay.text = "Brainz eaten: " + currentBr.ToString("F0");
        //mBPC.text = brPerClick + " Brainz/Click";
        mBPC.text = brPerClick.ToString("F0") + " Brainz/Click";
    }

    public void Clicked()
    {
        currentBr += brPerClick;
    }

}
