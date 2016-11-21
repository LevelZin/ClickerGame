using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

    public UnityEngine.UI.Text mGoldDisplay;
    
    public float currentGold = 0.0f;
    public float goldPerClick = 1.0f;

    void Update()
    {
        mGoldDisplay.text = "Gold: " + currentGold;
    }

    public void Clicked()
    {
        currentGold += goldPerClick;
    }

}
