using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Globalization;

public class Click : MonoBehaviour {

    [SerializeField]
    private Text mBrDisplay;
    [SerializeField]
    private Text mBPC;
    
    public float currentBr = 0.0f;
    public float brPerClick = 1.0f;

    void Update()
    {
        mBrDisplay.text = "Brainz eaten: " + (currentBr.ToString("N0", CultureInfo.CreateSpecificCulture("sv-SE")));
        //mBPC.text = brPerClick + " Brainz/Click";
        mBPC.text = brPerClick.ToString("N0", CultureInfo.CreateSpecificCulture("sv-SE")) + " Brainz/Click";
    }

    public void Clicked()
    {
        currentBr += brPerClick;
    }

}
