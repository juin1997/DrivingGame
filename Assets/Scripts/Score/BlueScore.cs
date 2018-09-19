using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueScore : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        ModeScore.CurrentScore += 25;
        gameObject.SetActive(false);
    }
}
