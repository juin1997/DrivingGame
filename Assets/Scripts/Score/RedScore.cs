using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScore : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        ModeScore.CurrentScore += 100;
        gameObject.SetActive(false);
    }
}
