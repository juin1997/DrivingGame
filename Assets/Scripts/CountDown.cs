using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class CountDown : MonoBehaviour
{
    public GameObject countDown;
    public GameObject lapTimer;
    public AudioSource getReady;
    public AudioSource goAudio;
    public AudioSource levelMusic;
    public ModeScore modeScore;
    public CarController carControls;
    public CarAIControl opponentControls;

	void Start ()
    {
        StartCoroutine(CountStart());
	}

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        for(int i = 3; i> 0; i--)
        {
            countDown.GetComponent<Text>().text = i.ToString();
            getReady.Play();
            countDown.SetActive(true);
            yield return new WaitForSeconds(1);
            countDown.SetActive(false);
        }
        goAudio.Play();
        lapTimer.SetActive(true);
        carControls.enabled = true;
        opponentControls.enabled = true;
        modeScore.enabled = true;
        levelMusic.Play();
    }

}
