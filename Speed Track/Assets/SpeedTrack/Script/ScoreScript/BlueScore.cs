using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueScore : MonoBehaviour {


    void OnTriggerEnter()
    {
        ScoreMode.CurrentScore += 200;
        gameObject.SetActive(false);
    }
}
