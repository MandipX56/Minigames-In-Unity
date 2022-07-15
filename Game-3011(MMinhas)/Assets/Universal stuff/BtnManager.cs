using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnManager : MonoBehaviour
{

    public void Title()
    {
        SceneManager.LoadScene("Main Scene");
    }


    public void PlayAssignment1()
    {
        SceneManager.LoadScene("Instructions1");

    }
    public void PlayGame1()
    {
        SceneManager.LoadScene("Game1");

    }



    public void PlayAssignment2()
    {
        SceneManager.LoadScene("Instructions2");

    }

    public void PlayGame2()
    {
        SceneManager.LoadScene("Game2");

    }
    public void PlayGame2nml()
    {
        SceneManager.LoadScene("Game2.1");

    }
    public void PlayGame2hrd()
    {
        SceneManager.LoadScene("Game2.2");

    }



    public void PlayAssignment3()
    {
        SceneManager.LoadScene("Instructions3");

    }
    public void PlayGame3()
    {
        SceneManager.LoadScene("Game3");

    }
    public void PlayGame3nml()
    {
        SceneManager.LoadScene("Game3.1");

    }
    public void PlayGame3hrd()
    {
        SceneManager.LoadScene("Game3.2");

    }



    public void PlayAssignment4()
    {
        SceneManager.LoadScene("Instructions4");

    }

    public void PlayGame4()
    {
        SceneManager.LoadScene("Game4");

    }

    public void PlayGame4nrml ()
    {
        SceneManager.LoadScene("Game4.1");

    }

    public void PlayGame4hrd()
    {
        SceneManager.LoadScene("Game4.2");

    }



    public void quitGame()
    {
        Application.Quit();
        Debug.Log("it's working!");

    }

}
