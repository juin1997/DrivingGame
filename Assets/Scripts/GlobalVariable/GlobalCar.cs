using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{
    //1=红色，2=紫色，3=绿色
    public static int CarType;
    public GameObject ModeSelect;

    public void RedCar()
    {
        CarType = 1;
        ModeSelect.SetActive(true);
    }

    public void PurpleCar()
    {
        CarType = 2;
        ModeSelect.SetActive(true);
    }

    public void GreenCar()
    {
        CarType = 3;
        ModeSelect.SetActive(true);
    }
}
