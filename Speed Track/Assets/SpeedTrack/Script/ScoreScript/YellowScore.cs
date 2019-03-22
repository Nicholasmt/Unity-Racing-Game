using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowScore : MonoBehaviour {

    void OnTriggerEnter()
    {
        ScoreMode.CurrentScore += 300;
        gameObject.SetActive(false);
    }
}
