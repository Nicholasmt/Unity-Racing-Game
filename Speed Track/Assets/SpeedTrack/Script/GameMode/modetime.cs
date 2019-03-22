using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modetime : MonoBehaviour {
    public int ModeSelcet01;
    public GameObject AIcar;
    


    public  static bool IstimeMode = false;

    void Start () {
        ModeSelcet01 = ModeSelect.RaceMode;

       if (ModeSelcet01 == 2)
        {
            
            AIcar.SetActive(false);
            IstimeMode = true;



        }
    }
	 
	void Update () {
		
	}
}
