using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class CountDown : MonoBehaviour
{
    public GameObject countDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public AudioSource LevelMusic;
    public GameObject LapTimer;
    public CarController CarControls;
    public CarAIControl OpponentControls;

	void Start ()
    {
        StartCoroutine(CountStart());
	}

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        countDown.GetComponent<Text>().text = "3";
        GetReady.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "2";
        GetReady.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "1";
        GetReady.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        GoAudio.Play();

        LapTimer.SetActive(true);
        CarControls.enabled = true;
        OpponentControls.enabled = true;
        LevelMusic.Play();
    }

}
