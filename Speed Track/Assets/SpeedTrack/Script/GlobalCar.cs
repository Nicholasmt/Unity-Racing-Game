using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour {

	 public static  int cartype;
    public GameObject TrackWindow;


        public void WhiteCar()
    {
        cartype = 1;
       TrackWindow.SetActive(true);
    }

    public void RedCar()
    {
        cartype = 2;
        TrackWindow.SetActive(true);
    }


}
