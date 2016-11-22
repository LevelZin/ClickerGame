using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Click : MonoBehaviour {

    [SerializeField]
    private Text mGoldDisplay;
    [SerializeField]
    private Text mGPC;
    
    public float currentGold = 0.0f;
    public float goldPerClick = 1.0f;

    void Update()
    {
        mGoldDisplay.text = "Gold: " + currentGold;
        mGPC.text = goldPerClick + " Gold/Click";
    }

    public void Clicked()
    {
        currentGold += goldPerClick;
    }

}
