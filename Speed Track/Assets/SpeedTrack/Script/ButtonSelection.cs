using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSelection : MonoBehaviour {

    //public void PlayGame()
    //{

     //   SceneManager.LoadScene(2);
   // }
    public void PlayGame()
    {
     SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    //Below here are Track select Buttons

    public void Track01()
    {
        SceneManager.LoadScene(3);
    }

    public void Track02()
    {
        SceneManager.LoadScene(4);
    }

    public void Track03()
    {
        SceneManager.LoadScene(5);
    }

    public void Credits()
    {
        SceneManager.LoadScene(7);
    
    }

    public void GameMode()
    {

        SceneManager.LoadScene(6);
    }


}
