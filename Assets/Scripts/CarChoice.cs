using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject redBody;
    public GameObject purpleBody;
    public GameObject greenBody;
    public int CarImport;

	void Start ()
    {
        CarImport = GlobalCar.CarType;
        if (CarImport == 1) redBody.SetActive(true);
        if (CarImport == 2) purpleBody.SetActive(true);
        if (CarImport == 3) greenBody.SetActive(true);
    }
	
}
