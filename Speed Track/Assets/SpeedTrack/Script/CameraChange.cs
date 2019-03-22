using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    public GameObject Normalcam;
    public GameObject Farcam;
    public GameObject FPCcam;
    public int  camMode;

    public void Update()
    {
        if (Input.GetButtonDown("ViewMode"))
        {
          if(camMode == 2)
            {
                camMode = 0;
            }
          else{
                camMode += 1;
            }
            StartCoroutine (ModeChange());

            }
       }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);

        if (camMode == 0){
            Normalcam.SetActive(true);
            FPCcam.SetActive(false);
        }

        if(camMode == 1)
        {
            Farcam.SetActive(true);
            Normalcam.SetActive(false);
        }

        if(camMode == 2)
        {
            FPCcam.SetActive(true);
            Farcam.SetActive(false);
        }
    }

}
