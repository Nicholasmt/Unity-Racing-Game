using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dreamer : MonoBehaviour {


    public GameObject Themaker;
    
    public GameObject Mark01;
    public GameObject Mark02;
    public GameObject Mark03;
    public GameObject Mark04;
    public GameObject Mark05;
    public GameObject Mark06;
    public GameObject Mark07;
    public GameObject Mark08;
    public GameObject Mark09;
    public GameObject Mark10;
    public GameObject Mark11;
    public GameObject Mark12;
    public GameObject Mark13;
    public GameObject Mark14;
    public GameObject Mark15;
    public GameObject Mark16;
    public GameObject Mark17;
    public GameObject Mark18;
    public GameObject Mark19;
    public GameObject Mark20;
    public int MarkTracker;

    void Update () {

        if (MarkTracker == 0) {
            Themaker.transform.position = Mark01.transform.position;
           }
        if (MarkTracker == 1)
        {
            Themaker.transform.position = Mark02.transform.position;
        }
        if (MarkTracker == 2)
        {
            Themaker.transform.position = Mark03.transform.position;
        }
        if (MarkTracker == 3)
        {
            Themaker.transform.position = Mark04.transform.position;

        }
        if (MarkTracker == 4)
        {
            Themaker.transform.position = Mark05.transform.position;
        }
        if (MarkTracker == 5)
        {
            Themaker.transform.position = Mark06.transform.position;
        }
        if (MarkTracker == 6)
        {
            Themaker.transform.position = Mark07.transform.position;
        }
        if (MarkTracker == 7)
        {
            Themaker.transform.position = Mark08.transform.position;
        }
        if (MarkTracker == 8)
        {
            Themaker.transform.position = Mark09.transform.position;
        }
        if (MarkTracker == 9)
        {
            Themaker.transform.position = Mark10.transform.position;
        }
        if (MarkTracker == 10)
        {
            Themaker.transform.position = Mark11.transform.position;
        }
        if (MarkTracker == 11)
        {
            Themaker.transform.position = Mark12.transform.position;
        }
        if (MarkTracker == 12)
        {
            Themaker.transform.position = Mark13.transform.position;
        }
        if (MarkTracker == 13)
        {
            Themaker.transform.position = Mark14.transform.position;
        }
        if (MarkTracker == 14)
        {
            Themaker.transform.position = Mark15.transform.position;
        }
        if (MarkTracker == 15)
        {
            Themaker.transform.position = Mark16.transform.position;
        }
        if (MarkTracker == 16)
        {
            Themaker.transform.position = Mark17.transform.position;
        }
        if (MarkTracker == 17)
        {
            Themaker.transform.position = Mark18.transform.position;
        }
        if (MarkTracker == 18)
        {
            Themaker.transform.position = Mark19.transform.position;
        }
        if (MarkTracker == 19)
        {
            Themaker.transform.position = Mark20.transform.position;
        }

    }


       IEnumerator OnTriggerEnter(Collider collision) {

        if (collision.gameObject.tag == "Dreamcar01") {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == 20) {
                MarkTracker = 0;
            }

            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }

    }
        
        

}
