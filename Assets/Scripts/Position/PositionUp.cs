using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionUp : MonoBehaviour
{
    public GameObject PositionDisplay;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "CarPos")
        {
            PositionDisplay.GetComponent<Text>().text = "第一名";
        }
    }

}
