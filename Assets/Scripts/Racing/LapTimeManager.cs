using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static int MinuteCount;
    public static int SecondCount;
    public static float MiliCount;
    public static string MiliDisplay;

    public Text MinuteBox;
    public Text SecondBox;
    public Text MiliBox;

    public static float RawTime;
	
	// Update is called once per frame
	void Update ()
    {
        MiliCount += Time.deltaTime * 10;
        RawTime += Time.deltaTime;
        MiliDisplay = MiliCount.ToString("F0");
        MiliBox.text = "" + MiliDisplay;

        if (MiliCount >= 10)
        {
            MiliCount = 0;
            SecondCount++;
        }
        if(SecondCount <= 9) SecondBox.text = "0" + SecondCount + ".";
        else SecondBox.text = SecondCount + ".";

        if (SecondCount >= 60)
        {
            SecondCount = 0;
            MinuteCount++;
        }
        if (MinuteCount <= 9) MinuteBox.text = "0" + MinuteCount + ":";
        else MinuteBox.text = MinuteCount + ":";
    }
}
