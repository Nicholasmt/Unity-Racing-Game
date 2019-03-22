using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartypeSelect1 : MonoBehaviour {

    public GameObject WhiteBody;
    public GameObject RedBody;
    public GameObject BlueBody;
    public GameObject YellowBody;
    public GameObject BrownBody;
    public int carimport;


    public void Start()
    {
        carimport = CarColorselect.CarColor;
        if (carimport == 1)
        {
            BlueBody.SetActive(true);
            YellowBody.SetActive(false);
            RedBody.SetActive(false);
            BrownBody.SetActive(false);
            WhiteBody.SetActive(false);

        }
        if (carimport == 2)
        {
            BlueBody.SetActive(false);
            YellowBody.SetActive(false);
            RedBody.SetActive(true);
            BrownBody.SetActive(false);
            WhiteBody.SetActive(false);
        }

        if (carimport == 3)
        {
            BlueBody.SetActive(false);
            YellowBody.SetActive(false);
            RedBody.SetActive(false);
            BrownBody.SetActive(true);
            WhiteBody.SetActive(false);
        }

        if (carimport == 4)
        {
            BlueBody.SetActive(false);
            YellowBody.SetActive(true);
            RedBody.SetActive(false);
            BrownBody.SetActive(false);
            WhiteBody.SetActive(false);
        }

        if (carimport == 5)
        {
            BlueBody.SetActive(false);
            YellowBody.SetActive(false);
            RedBody.SetActive(false);
            BrownBody.SetActive(false);
            WhiteBody.SetActive(true);
        }

    }
}
