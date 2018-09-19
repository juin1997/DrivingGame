using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeTime : MonoBehaviour {
    public int ModeSelected;
    public GameObject PositionDisplay;
    public GameObject AICar;
    public static bool isModeTime = false;

	void Start ()
    {
        ModeSelected = ModeSelect.RaceMode;
        if(ModeSelected == 2)
        {
            isModeTime = true;
            PositionDisplay.SetActive(false);
            AICar.SetActive(false);
        }	
	}

}
