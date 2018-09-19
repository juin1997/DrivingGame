using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeScore : MonoBehaviour {
    public int ModeSelected;
    public GameObject RaceUI;
    public GameObject ScoreUI;
    public GameObject AICar;
    public GameObject ScoreDisplay;
    public GameObject ScoreObjects;
    public GameObject PositionDisplay;
    public static int CurrentScore;
    public int InternalScore;

	void Start ()
    {
        ModeSelected = ModeSelect.RaceMode;
        if(ModeSelected == 1)
        {
            RaceUI.SetActive(false);
            PositionDisplay.SetActive(false);
            ScoreUI.SetActive(true);
            AICar.SetActive(false);
            ScoreObjects.SetActive(true);
        }
		
	}

    private void Update()
    {
        InternalScore = CurrentScore;
        ScoreDisplay.GetComponent<Text>().text = "" + InternalScore;
    }


}
