using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarColorselect : MonoBehaviour {
    
    public GameObject redcar1;
    public GameObject whitecar2;
    public GameObject browncar3;
    public GameObject bluecar4;
    public GameObject yellowcar5;
    public GameObject tractselectionpanel01;
    public GameObject tractselectionpanel02;
    public static int CarColor;
   // public GameObject text02;
   // public GameObject text01;
   // public GameObject NextButton;

    public void Next()
    {

        tractselectionpanel01.SetActive(true);
        tractselectionpanel02.SetActive(false);
        
        
        //text01.SetActive(false);
        // text02.SetActive(true);
       // NextButton.SetActive(false);


    }


    public void bluecar()
    {
        CarColor= 1;
       bluecar4.SetActive(true);
        redcar1.SetActive(false);
        yellowcar5.SetActive(false);
        browncar3.SetActive(false);
        whitecar2.SetActive(false);
    }
    public void redcar()
    {
        CarColor = 2;
        bluecar4.SetActive(false);
        redcar1.SetActive(true);
        yellowcar5.SetActive(false);
        browncar3.SetActive(false);
        whitecar2.SetActive(false);
    }
    public void browncar()
    {
        CarColor = 3;
        bluecar4.SetActive(false);
        redcar1.SetActive(false);
        yellowcar5.SetActive(false);
        browncar3.SetActive(true);
        whitecar2.SetActive(false);
    }
    public void yellowcar()
    {
        CarColor = 4;
        bluecar4.SetActive(false);
        redcar1.SetActive(false);
        yellowcar5.SetActive(true);
        browncar3.SetActive(false);
        whitecar2.SetActive(false);
    }
    public void whitecar()
    {
        CarColor = 5;
        bluecar4.SetActive(false);
        redcar1.SetActive(false);
        yellowcar5.SetActive(false);
        browncar3.SetActive(false);
        whitecar2.SetActive(true);
    }

}
