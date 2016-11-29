using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {

    public Click click;
    public Text itemInfo;
    public Text UpgrAvailable;
    public float upgradeCost;
    public int count = 0;
    public float clickPower;
    public string itemName;
    private float baseCost;
    public GameObject button;

    void start()
    {
        baseCost = upgradeCost;
    }

    void Update()
    {
        itemInfo.text = itemName + "\nCost: " + upgradeCost + "\nPower + " + clickPower;

        if (click.currentBr >= upgradeCost)
        {
            UpgrAvailable.GetComponent<Text>().enabled = true;
            button.GetComponent<Button>().interactable = true;
        }
        else
        {
            UpgrAvailable.GetComponent<Text>().enabled = false;
            button.GetComponent<Button>().interactable = false;
        }
    }

    public void PurchaseUpgrade()
    {
        if(click.currentBr >= upgradeCost)
        {
            click.currentBr -= upgradeCost;
            count++;
            click.brPerClick += clickPower;
            upgradeCost = Mathf.Round(upgradeCost * Mathf.Pow(1.15f, count));
            clickPower = Mathf.Round(clickPower * Mathf.Pow(1.15f, count));
        }
        
    }

}
