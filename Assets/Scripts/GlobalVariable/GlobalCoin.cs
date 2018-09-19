using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCoin : MonoBehaviour
{
    public int Coin;
    public static int CoinsValue;
    public GameObject CoinDisplay;
	
	void Start () {
        CoinsValue = PlayerPrefs.GetInt("Coin");
	}
	
	
	void Update ()
    {
        Coin = CoinsValue;
        CoinDisplay.GetComponent<Text>().text = "金币:" + Coin;
	}
}
