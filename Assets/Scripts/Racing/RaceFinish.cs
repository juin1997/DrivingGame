using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour {

    public GameObject car;
    public GameObject FinishCam;
    public GameObject CamCube;
    public GameObject ViewModes;
    public GameObject LevelMusic;
    public GameObject CompleteTrig;
    public GameObject TimeManager;
    public GameObject FinishOption;
    public Text MiliDisplay;
    public Text Coin;
    public Text Position;
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
            Coin.text += (ModeScore.CurrentScore * 0.2f).ToString();
            GlobalCoin.CoinsValue += Convert.ToInt32(ModeScore.CurrentScore * 0.2f);
            PlayerPrefs.SetInt("Coin", GlobalCoin.CoinsValue);
            StartCoroutine(ShowFinishOption());
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
            if (Position.text == "第一名")
            {
                GlobalCoin.CoinsValue += 100;
                Coin.text += "100";
            }
            else
            {
                GlobalCoin.CoinsValue += 50;
                Coin.text += "50";
            }
            PlayerPrefs.SetInt("Coin", GlobalCoin.CoinsValue);
            StartCoroutine(ShowFinishOption());
        }
    }

    IEnumerator ShowFinishOption()
    {
        yield return new WaitForSeconds(3);
        FinishCam.SetActive(false);
        CamCube.SetActive(true);
        FinishOption.SetActive(true);
    }
}
