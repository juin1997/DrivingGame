using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionUp : MonoBehaviour
{
    public Text PositionDisplay;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("CarPos"))
        {
            PositionDisplay.text = "第一名";
        }
    }

}
