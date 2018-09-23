using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionDown : MonoBehaviour
{
    public Text PositionDisplay;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CarPos"))
        {
            PositionDisplay.text = "第二名";
        }
    }
}
