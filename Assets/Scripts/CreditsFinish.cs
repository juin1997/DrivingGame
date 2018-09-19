using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CreditsFinish : MonoBehaviour {

	
	void Start ()
    {
        StartCoroutine(FinishCredits());
	}

    IEnumerator FinishCredits()
    {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene(0);
    }
	
}
