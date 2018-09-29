using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject frontButton;
    public GameObject menuButton;
    public Text startText;

    public void ClickToStartGame()
    {
        frontButton.SetActive(false);
        startText.text = "";
        menuButton.SetActive(true);
    }
}
