using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMode : MonoBehaviour {

    public int ModeSelcetion;
    public int InternalScore;
    public GameObject RaceUI;
    public GameObject ScoreUI;
    public GameObject Aicar;
    public static int CurrentScore;
    public GameObject ScoreValue;
    public GameObject ScoreObject;
    
  
    public void  Start() {

        ModeSelcetion = ModeSelect.RaceMode;

        if (ModeSelcetion == 1)
        {

            RaceUI.SetActive(false);
            ScoreUI.SetActive(true);
            Aicar.SetActive(false);
            ScoreObject.SetActive(true);

        }
    }

    public void Update()
    {
        InternalScore = CurrentScore;
        ScoreValue.GetComponent<Text>().text = "" + InternalScore;
    }
	
	
}
