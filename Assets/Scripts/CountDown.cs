using System.Collections;
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

	void Start ()
    {
        CarController.m_Topspeed = 0;
        StartCoroutine(CountStart());
	}

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.2f);
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
        CarController.m_Topspeed = 200;
        modeScore.enabled = true;
        levelMusic.Play();
    }

}
