using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI coinsText;
    private int score = CollectingCoins.coin;

    private void Start()
    {
        coinsText.text = score.ToString() + " Coins";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("SkyTrails");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Main Menu");

    }
}
