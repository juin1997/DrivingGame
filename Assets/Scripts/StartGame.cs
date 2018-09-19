using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject frontButton;
    public GameObject menuButton;
    public GameObject startButton;

    public void ClickToStartGame()
    {
        frontButton.SetActive(false);
        startButton.SetActive(false);
        menuButton.SetActive(true);
    }
}
