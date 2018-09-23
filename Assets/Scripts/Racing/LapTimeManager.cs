using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static int MinuteCount;
    public static int SecondCount;
    public static float MiliCount;
    public static string MiliDisplay;
    public static float RawTime;

    public Text MinuteBox;
    public Text SecondBox;
    public Text MiliBox;
    public StringBuilder sb = new StringBuilder();

	
	void Update ()
    {
        sb.Remove(0, sb.Length);
        MiliCount += Time.deltaTime * 10;
        RawTime += Time.deltaTime;
        MiliDisplay = MiliCount.ToString("F0");
        MiliBox.text = MiliDisplay.ToString();

        if (MiliCount >= 10)
        {
            MiliCount = 0;
            SecondCount++;
        }
        if (SecondCount <= 9)
        {
            sb.Append("0");
            sb.Append(SecondCount);
            sb.Append(".");
            SecondBox.text = sb.ToString(); ;
        }
        else
        {
            sb.Append(SecondCount);
            sb.Append(".");
            SecondBox.text = sb.ToString();
        }
        sb.Remove(0, sb.Length);
        if (SecondCount >= 60)
        {
            SecondCount = 0;
            MinuteCount++;
        }
        if (MinuteCount <= 9)
        {
            sb.Append("0");
            sb.Append(MinuteCount);
            sb.Append(":");
            MinuteBox.text = sb.ToString();
        }
        else
        {
            sb.Append(MinuteCount);
            sb.Append(":");
            MinuteBox.text = sb.ToString();
        }
    }
}
