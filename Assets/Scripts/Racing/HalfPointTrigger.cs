using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    void OnTriggerEnter(Collider other)
    {
        HalfLapTrig.SetActive(false);
        LapCompleteTrig.SetActive(true);
    }
}
