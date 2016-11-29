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
        brpsDisplay.text = GetBrPerSec() + " Brainz/Second";
    }

    public int GetBrPerSec()
    {
        int tick = 0;
        foreach(ItemManager item in items)
        {
            tick += item.count * item.tickValue;
        }
        return tick;
    }

    public void AutoBrPerSec()
    {
        click.currentBr += GetBrPerSec();
    }

    IEnumerator AutoTick()
    {
        while (true)
        {
            AutoBrPerSec();
            yield return new WaitForSeconds(1);
        }
    }
	
}
