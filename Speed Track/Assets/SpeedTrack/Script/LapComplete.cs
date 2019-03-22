using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour {

    public GameObject LapCompleteTrig;
    public GameObject halfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilleDisplay;

    public GameObject LapTimeBox;

    public GameObject LapCounter;
    public int LapDone;
    public float RawTime;
    public GameObject RaceFinish;


    public void Update()
    {
        if(LapDone == 1)
        {
            RaceFinish.SetActive(true);

        }
    }

    public void OnTriggerEnter()
    {
        LapDone += 1;
        RawTime = PlayerPrefs.GetFloat("RawTime");
        if (lapTimemanager.RawTime <= RawTime)
        {



            if (lapTimemanager.Secondscount <= 9)
            {
                SecondDisplay.GetComponent<Text>().text = "0" + lapTimemanager.Secondscount + ".";
            }
            else
            {
                SecondDisplay.GetComponent<Text>().text = "" + lapTimemanager.Secondscount + ".";
            }


            if (lapTimemanager.minutecount <= 9)
            {
                MinuteDisplay.GetComponent<Text>().text = "0" + lapTimemanager.minutecount + ".";
            }
            else
            {
                MinuteDisplay.GetComponent<Text>().text = "" + lapTimemanager.minutecount + ".";
            }

            MilleDisplay.GetComponent<Text>().text = "" + lapTimemanager.minutecount;

        }

        PlayerPrefs.SetInt("MinSave", lapTimemanager.minutecount);
        PlayerPrefs.SetInt("SecSave", lapTimemanager.Secondscount);
        PlayerPrefs.SetFloat("MilleSave", lapTimemanager.Millecount);
        PlayerPrefs.SetFloat("RawTime", lapTimemanager.RawTime);

        lapTimemanager.minutecount = 0;
        lapTimemanager.Secondscount = 0;
        lapTimemanager.Millecount = 0;
        lapTimemanager.RawTime = 0;
        LapCounter.GetComponent<Text>().text = "" + LapDone;
        halfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);

        
    }

	 
}
