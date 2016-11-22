using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoldPerSecond : MonoBehaviour {

    public Text gpsDisplay;
    public Click click;
    public ItemManager[] items;

    void Start()
    {
        StartCoroutine(AutoTick());
    }

    void Update()
    {
        gpsDisplay.text = GetGoldPerSec() + " Gold/Second";
    }

    public int GetGoldPerSec()
    {
        int tick = 0;
        foreach(ItemManager item in items)
        {
            tick += item.count * item.tickValue;
        }
        return tick;
    }

    public void AutoGoldPerSec()
    {
        click.currentGold += GetGoldPerSec();
    }

    IEnumerator AutoTick()
    {
        while (true)
        {
            AutoGoldPerSec();
            yield return new WaitForSeconds(1);
        }
    }
	
}
