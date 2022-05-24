using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text coinsText;
    public Text totalCoinsText;

    private int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("TotalCoins", 0);
        coinsText.text = "Coins: "+ CollectingCoins.coin.ToString();
        totalCoinsText.text = "Total Coins: " + highscore;
    }

    public void addCoin()
    {
        coinsText.text = "Coins: "+ CollectingCoins.coin.ToString();
        PlayerPrefs.SetInt("TotalCoins", highscore);

    }
}
