using UnityEngine;
using System.Collections;

public class Converter : MonoBehaviour {

	private static Converter instance;
    public static Converter Instance
    {
        get
        {
            return instance;
        }
    }

    void awake()
    {
        CreateInstance();
    }

    void CreateInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public string GetCurrencyIntoString(float valueToConvert, bool currencyPerSec, bool currencyPerClick)
    {
        string converted;
        converted = valueToConvert.ToString("F0");

        return converted;
    }
    
}
