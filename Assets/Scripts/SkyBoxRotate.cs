using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxRotate : MonoBehaviour {

    public float rotateSpeed = 1;

	void Update ()
    {
        RenderSettings.skybox.SetFloat("_Rotation", rotateSpeed * Time.time);
	}
}
