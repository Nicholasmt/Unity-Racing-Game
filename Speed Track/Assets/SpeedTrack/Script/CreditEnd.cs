﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditEnd : MonoBehaviour {

	 
	void Start () {
        StartCoroutine(CreditFinish());	
	}

    IEnumerator CreditFinish()
    {
        yield return new WaitForSeconds(12);
        SceneManager.LoadScene(0);
    }
}
