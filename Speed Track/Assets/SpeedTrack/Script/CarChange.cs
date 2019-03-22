using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChange : MonoBehaviour {
    public GameObject car1;
    public GameObject car2;
    



    public void Car01()
    {
        car1.SetActive(true);
        car2.SetActive(false);

    }
    public void Car02()
    {
        car2.SetActive(true);
        car1.SetActive(false);
    }
}
