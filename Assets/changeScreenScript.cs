using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changeScreenScript : MonoBehaviour
{
    public void changeToGameScreen()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void gameQuit()
    {
        Application.Quit();
    }
}
