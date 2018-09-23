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
    public Text MiliDisplay;
    public AudioSource FinishMusic;
    public ModeScore modeScore;

    private void OnTriggerEnter(Collider other)
    {
        if (ModeTime.isModeTime)
        {
            //在记时模式
        }
        else if(ModeScore.isModeScore)
        {
            // 在计分模式
            this.GetComponent<BoxCollider>().enabled = false;
            car.SetActive(false);
            CompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            car.GetComponent<CarController>().enabled = false;
            car.GetComponent<CarUserControl>().enabled = false;
            car.SetActive(true);
            modeScore.enabled = false;
            FinishCam.SetActive(true);
            LevelMusic.SetActive(false);
            ViewModes.SetActive(false);
            TimeManager.SetActive(false);
            MiliDisplay.text = "0";
            FinishMusic.Play();
            
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
            MiliDisplay.text = "0";
            FinishMusic.Play();
            GlobalCoin.CoinsValue += 100;
            PlayerPrefs.SetInt("Coin", GlobalCoin.CoinsValue);
        }
    }
}
