using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
        brpsDisplay.text = GetBrPerSec().ToString("F0") + " Brainz/Second";
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
        click.currentBr += GetBrPerSec() / 100;
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
