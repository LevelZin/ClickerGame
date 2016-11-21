using UnityEngine;
using System.Collections;

public class UpdateManager : MonoBehaviour {

    public Click click;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count = 0;
    public float clickPower;
    public string itemName;
    private float mNewCost;

    void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nPower + " + clickPower;
    }

    public void PurchasedUpgrade()
    {
        if(click.currentGold >= cost)
        {
            click.currentGold -= cost;
            count ++;
            click.goldPerClick += clickPower;
            cost = Mathf.Round(cost * 1.15f);
            mNewCost = Mathf.Pow(cost, mNewCost = cost);

        }
    }

}
