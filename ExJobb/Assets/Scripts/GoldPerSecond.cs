using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Globalization;

public class GoldPerSecond : MonoBehaviour {

    public Text brpsDisplay;
    public Click click;
    public ItemManager[] items;

    void Start()
    {
        StartCoroutine(AutoTick());
    }

    void Update()
    {
        //brpsDisplay.text = GetBrPerSec() + " Brainz/Second";
        brpsDisplay.text = GetBrPerSec().ToString("N0", CultureInfo.CreateSpecificCulture("sv-SE")) + " Brainz/Second";
    }

    public float GetBrPerSec()
    {
        float tick = 0;
        foreach(ItemManager item in items)
        {
            tick += item.count * item.tickValue;
        }
        return tick;
    }

    public void AutoBrPerSec()
    {
        float debugBr = 0.0f;
        click.currentBr += GetBrPerSec() / 100;
        //Debug.Log("Total Brainz based on BPS: " + (debugBr += GetBrPerSec()));
    }

    IEnumerator AutoTick()
    {
        while (true)
        {
            AutoBrPerSec();
            yield return new WaitForSeconds(0.01f);
        }
    }
	
}
