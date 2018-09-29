using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ModeScore : MonoBehaviour {
    
    public GameObject RaceUI;
    public GameObject ScoreUI;
    public GameObject AICar;
    public GameObject ScoreObjects;
    public GameObject PositionDisplay;
    public GameObject TimeOut;
    public Text ScoreDisplay;
    public Text MinCountDown;
    public Text SecCountDown;
    public Text MiliCountDown;
    public Text TOCoin;
    public int InternalScore;
    public int ModeSelected;
    public StringBuilder sb = new StringBuilder();
    public static bool isModeScore = false;
    public static int CurrentScore;

    private int minute = 1;
    private int second = 30;
    private float miliSecond = 0;

    void Awake()
    {
        ModeSelected = ModeSelect.RaceMode;
        if(ModeSelected == 1)
        {
            isModeScore = true;
            MinCountDown.text = "01:";
            SecCountDown.text = "30.";
            MiliCountDown.text = "0";
            RaceUI.SetActive(false);
            PositionDisplay.SetActive(false);
            ScoreUI.SetActive(true);
            AICar.SetActive(false);
            ScoreObjects.SetActive(true);
        }
		
	}

    private void Update()
    {
        if (ModeSelected == 1)
        {
            miliSecond -= Time.deltaTime * 10;
            if(miliSecond < 0)
            {
                miliSecond = 9;
                second--;
            }
            if(second < 0)
            {
                second = 59;
                minute--;
            }
            if(minute < 0)
            {
                Time.timeScale = 0;
                InternalScore = InternalScore > 200 ? InternalScore - 200 : 0;
                TOCoin.text += InternalScore.ToString();
                TimeOut.SetActive(true);
                this.enabled = false;
                return;
            }
            ShowCountDown();
            InternalScore = CurrentScore;
            ScoreDisplay.text = InternalScore.ToString();
        }
    }

    private void ShowCountDown()
    {
        sb.Remove(0, sb.Length);
        sb.Append("0");
        sb.Append(minute);
        sb.Append(":");
        MinCountDown.text = sb.ToString();
        sb.Remove(0, sb.Length);
        if (second < 10) sb.Append("0");
        sb.Append(second);
        sb.Append(".");
        SecCountDown.text = sb.ToString();
        MiliCountDown.text = miliSecond.ToString("F0");
    }


}
