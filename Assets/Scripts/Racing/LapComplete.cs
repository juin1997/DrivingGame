using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MiliDisplay;
    public GameObject LapTimeBox;
    public GameObject RaceFinish;
    public GameObject LapCounter;
    public int LapsDone;
    public float RawTime;

    private void OnTriggerEnter(Collider other)
    {
        LapsDone++;
        if(RawTime == 0)
        {
            if (LapTimeManager.SecondCount <= 9) SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
            else SecondDisplay.GetComponent<Text>().text = LapTimeManager.SecondCount + ".";

            if (LapTimeManager.MinuteCount <= 9) MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
            else MinuteDisplay.GetComponent<Text>().text = LapTimeManager.MinuteCount + ".";

            MiliDisplay.GetComponent<Text>().text = LapTimeManager.MiliCount.ToString("F0");
        }
        RawTime = PlayerPrefs.GetFloat("RawTime");
        if (LapTimeManager.RawTime <= RawTime)
        {
            if (LapTimeManager.SecondCount <= 9) SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
            else SecondDisplay.GetComponent<Text>().text = LapTimeManager.SecondCount + ".";

            if (LapTimeManager.MinuteCount <= 9) MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
            else MinuteDisplay.GetComponent<Text>().text = LapTimeManager.MinuteCount + ".";

            MiliDisplay.GetComponent<Text>().text = LapTimeManager.MiliCount.ToString("F0");
        }

        PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MiliCount = 0;
        LapTimeManager.RawTime = 0;
        LapCounter.GetComponent<Text>().text = LapsDone + "/1";

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
        if (LapsDone == 1)
        {
            RaceFinish.SetActive(true);
        }
    }
}
