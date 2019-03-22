using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceMode : MonoBehaviour {

    public GameObject RaceUI;
    public GameObject AIcar;
    public GameObject Scoreui;
    public int ModeSelcet01;



    public void Start () {
        ModeSelcet01 = ModeSelect.RaceMode;
        if (ModeSelcet01 == 3)
        {
            RaceUI.SetActive(true);
            AIcar.SetActive(true);
            Scoreui.SetActive(false);
        }
	}
	
	 
	public void Update () {
		
	}
}
