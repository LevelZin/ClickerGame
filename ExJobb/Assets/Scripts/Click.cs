using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Globalization;
using System;

public class Click : MonoBehaviour {

    [SerializeField]
    private Text mBrDisplay;
    [SerializeField]
    private Text mBPC;
    [SerializeField]
    private Text mPopulation;
    
    public float currentBr = 0.0f;
    public float brPerClick = 1.0f;
    public long longBrPerClick = 1;
    public float tempPop = 0.0f;
    public long population = 8000000000;
    public bool mEndGame = false;
    public float displayPop = 0.0f;
    
    void Update()
    {
        //displayPop = population;
        //displayPop.ToString();
        //Convert.ToInt64(displayPop);
        mBrDisplay.text = "Brainz in ztock: " + (currentBr.ToString("N0", CultureInfo.CreateSpecificCulture("sv-SE")));
        //mBrDisplay.text = "Brainz eaten: " + (Converter.Instance.GetCurrencyIntoString(currentBr, false, false));
        mPopulation.text = "Human Populazion: " + (population.ToString("N0", CultureInfo.CreateSpecificCulture("sv-SE")));
        //mBPC.text = brPerClick + " Brainz/Click";
        mBPC.text = brPerClick.ToString("N0", CultureInfo.CreateSpecificCulture("sv-SE")) + " Brainz/Click";

        if(population <= 0)
        {
            mEndGame = true;
        }
    }

    public void Clicked()
    {
        currentBr += brPerClick;
        longBrPerClick = Convert.ToInt64(brPerClick);
        population -= longBrPerClick;
    }

}
