using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class MainMenuScreen : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("SkyTrails");
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Quit");

    }
    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits");

    }
    public void ShopButton()
    {
        SceneManager.LoadScene("Shop");

    }
}
