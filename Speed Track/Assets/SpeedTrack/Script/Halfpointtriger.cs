using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Halfpointtriger : MonoBehaviour {
    public GameObject LabCompletetrig;
    public GameObject halfLabtrig;

  void OnTriggerEnter()
    {
        LabCompletetrig.SetActive(true);
        halfLabtrig.SetActive(false);

    }
	 
}
