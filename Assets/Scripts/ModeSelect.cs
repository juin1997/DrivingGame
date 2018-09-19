using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour
{
    //0 =竞速 ，1=计分，2=计时
    public static int RaceMode;
    public GameObject Mapselect;
	
    public void ScoreMode()
    {
        RaceMode = 1;
        Mapselect.SetActive(true);
    }

    public void TimeMode()
    {
        RaceMode = 2;
        Mapselect.SetActive(true);
    }

    public void RacingMode()
    {
        RaceMode = 0;
        Mapselect.SetActive(true);
    }

}
