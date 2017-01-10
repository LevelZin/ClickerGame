using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour {

    public Text itemInfo;
    public Click click;
    public Text UpgrAvailable;
    public float itemCost;
    public int tickValue;
    public int count;
    public string itemName;
    private float baseCost;
    public GameObject button;

    void Start()
    {
        baseCost = itemCost;
    }

    void Update()
    {
        if (click.currentBr >= itemCost)
            {
                UpgrAvailable.GetComponent<Text>().enabled = true;
                button.GetComponent<Button>().interactable = true;
            }
            else
            {
                UpgrAvailable.GetComponent<Text>().enabled = false;
                button.GetComponent<Button>().interactable = false;
            }
        
        //itemInfo.text = itemName + "\nCost: " + itemCost + "\nGold: " + tickValue + "/s";
        itemInfo.text = itemName + "\nCost: " + itemCost.ToString("F0") + "\nGold: " + tickValue + "/s";

    }

    public void PurchaseItem()
    {
        if(click.currentBr >= itemCost)
        {
            click.currentBr -= itemCost;
            count++;
            itemCost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count));
        }
    }
}
