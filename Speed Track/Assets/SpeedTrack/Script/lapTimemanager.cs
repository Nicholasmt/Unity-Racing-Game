using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lapTimemanager : MonoBehaviour {
    public static int minutecount;
    public static int Secondscount;
    public static float Millecount;
    public static string mileDisplay;

    public GameObject minuteBox;
    public GameObject SecondsBox;
    public GameObject MileBox;

    public static float RawTime;

      void Update ()
    {
        Millecount += Time.deltaTime * 10;
        RawTime += Time.deltaTime;
        mileDisplay = Millecount.ToString("F1");
        MileBox.GetComponent<Text> ().text = "" + mileDisplay;

        if (Millecount >= 10)
        {
            Millecount = 0;
            Secondscount += 1;
        }

        if (Secondscount <= 9 )
        {
            SecondsBox.GetComponent<Text>().text = "0" + Secondscount + ".";

        }
        else
        {
            SecondsBox.GetComponent<Text>().text = "" + Secondscount + ".";

        }


        if (Secondscount >= 60)
        {
            Secondscount = 0;
            minutecount += 1;
        }

        if(minutecount <= 9)
        {
            minuteBox.GetComponent<Text>().text = "0" + minutecount + ".";
        }
        else
        {
             minuteBox.GetComponent<Text>().text = "" + minutecount + ".";
        }

    }
     
	 
}
 