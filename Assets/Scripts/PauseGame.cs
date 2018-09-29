using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseUI;

    void Update ()
    {
        if (Input.GetButtonDown("Pause"))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pauseUI.SetActive(true);
            }
            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                pauseUI.SetActive(false);
            }
        }
     }
}
