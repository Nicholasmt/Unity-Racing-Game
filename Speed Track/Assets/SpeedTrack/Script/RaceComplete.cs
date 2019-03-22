using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceComplete : MonoBehaviour {


    public GameObject Mycar;
    public GameObject finishCam;
    public GameObject ViewMode;
    public GameObject LevelMusic;
    public GameObject CompleteTrig;
    public AudioSource finishMusic;

    




    public void OnTriggerEnter()  {
        if(modetime.IstimeMode == true)
        {
         //  Time Mode

        }
        else
        {
    this.GetComponent<BoxCollider>().enabled = false;
    Mycar.SetActive(false);
    CompleteTrig.SetActive(false);
    CarController.m_Topspeed = 0.0f;
    Mycar.GetComponent<CarController>().enabled = false;
    Mycar.GetComponent<CarUserControl>().enabled = false;
    Mycar.SetActive(true);
    finishCam.SetActive(true);
    LevelMusic.SetActive(false);
    ViewMode.SetActive(false);
    finishMusic.Play();
 
        }
  
    }

}
