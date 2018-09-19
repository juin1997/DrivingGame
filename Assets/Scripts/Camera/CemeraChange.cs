﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CemeraChange : MonoBehaviour
{
    public GameObject NormalCam;
    public GameObject FarCam;
    public GameObject FPCam;
    public int CamMode;

    private void Update()
    {
        if(Input.GetButton("ViewMode"))
        {
            if (CamMode == 2) CamMode = 0;
            else CamMode+=1;
            StartCoroutine(ModeChange());
        }
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.1f);
        if (CamMode == 0)
        {
            NormalCam.SetActive(true);
            FPCam.SetActive(false);
        }
        if (CamMode == 1)
        {
            FarCam.SetActive(true);
            NormalCam.SetActive(false);
        }
        if(CamMode == 2)
        {
            FPCam.SetActive(true);
            FarCam.SetActive(false);
        }

    }
}