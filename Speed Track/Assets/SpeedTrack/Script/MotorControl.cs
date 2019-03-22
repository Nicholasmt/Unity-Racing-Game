using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class MotorControl : MonoBehaviour {

    public GameObject CarControl;
    public GameObject CarAIcontrole;
    public GameObject CarAIcontrole2;
    public GameObject CarAudi;
    public GameObject Car;


    void Start () {
        CarControl.GetComponent<CarController>().enabled = true;
        CarAIcontrole.GetComponent<CarAIControl>().enabled = true;
        CarAIcontrole2.GetComponent<CarAIControl>().enabled = true;
        CarAudi.GetComponent<SimplCarController>().enabled = true;
        Car.GetComponent<CarController>().enabled = true;


    }


}
