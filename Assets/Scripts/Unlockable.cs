using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockable : MonoBehaviour {

    public GameObject greenButton;
    public int greenSelect;
    public int Coins;

    private void Start()
    {
        greenSelect = PlayerPrefs.GetInt("GreenBought");
        if(greenSelect == 100)
        {
            greenButton.SetActive(false);
        }
    }

    void Update () {
        Coins = GlobalCoin.CoinsValue;
        if(Coins >= 100)
        {
            greenButton.GetComponent<Button>().interactable = true;
        }
	}

    public void GreenUnlock()
    {
        greenButton.SetActive(false);
        Coins -= 100;
        GlobalCoin.CoinsValue -= 100;
        PlayerPrefs.SetInt("Coin", GlobalCoin.CoinsValue);
        PlayerPrefs.SetInt("GreenBought", 100);
    }

}
