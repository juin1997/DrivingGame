using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour {

    public GameObject car;
    public GameObject FinishCam;
    public GameObject ViewModes;
    public GameObject LevelMusic;
    public GameObject CompleteTrig;
    public GameObject TimeManager;
    public GameObject MiliDisplay;
    public AudioSource FinishMusic;

    private void OnTriggerEnter(Collider other)
    {
        if (ModeTime.isModeTime)
        {
            //在记时模式
        }
        else
        {
            this.GetComponent<BoxCollider>().enabled = false;
            car.SetActive(false);
            CompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            car.GetComponent<CarController>().enabled = false;
            car.GetComponent<CarUserControl>().enabled = false;

            car.SetActive(true);
            FinishCam.SetActive(true);
            LevelMusic.SetActive(false);
            ViewModes.SetActive(false);
            TimeManager.SetActive(false);
            MiliDisplay.GetComponent<Text>().text = "0";
            FinishMusic.Play();
            GlobalCoin.CoinsValue += 100;
            PlayerPrefs.SetInt("Coin", GlobalCoin.CoinsValue);
        }
    }
}
