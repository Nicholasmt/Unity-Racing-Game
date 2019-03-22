using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour {

 public int cashvalue;
    public static int TotalCash;
    public GameObject cashDisplay;

    public void Start()
    {
     cashvalue = TotalCash;
        cashDisplay.GetComponent <Text>().text = "Cash $" + cashvalue;
    }

}
