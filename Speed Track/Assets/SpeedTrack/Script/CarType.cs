using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarType : MonoBehaviour {
    public GameObject redBody;
    public GameObject WhiteBody;
    public int carimport;
    

    public void Start()
    {
        carimport = GlobalCar.cartype;
        if ( carimport == 1)
        {
            WhiteBody.SetActive(true);

        }
        if (carimport == 2)
        {
            redBody.SetActive(true);

        }
    }
}
