using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour {
    public int MinCount;
    public int SecCount;
    public int MilCount;
    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilDisplay;

    public void Start()
    {
        MinCount = PlayerPrefs.GetInt("MinSave");
        SecCount = PlayerPrefs.GetInt("SecSave");
        MilCount = PlayerPrefs.GetInt("MilleSave");

        MinDisplay.GetComponent<Text>().text = "" + MinCount;
        SecDisplay.GetComponent<Text>().text = "" + SecCount;
        MilDisplay.GetComponent<Text>().text = "" + MilCount;


    }
	 
}
