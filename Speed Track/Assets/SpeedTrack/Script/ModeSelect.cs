using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour {

    public static int RaceMode;   


    public void Score()
    {
        RaceMode = 1;

    }

    public void Time()
    {
        RaceMode = 2;

    }
    public void Race()
    {
        RaceMode = 3;

    }

}
