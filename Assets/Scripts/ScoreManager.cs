using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI totalCoinsText;
    
    public static int totalCoins = 0;

    
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        totalCoins = PlayerPrefs.GetInt("totalCoins", 0);
        coinsText.text = "Coins: "+ CollectingCoins.coin.ToString();
        totalCoinsText.text = "Total Coins: " + totalCoins.ToString();
    }
    

    public void addCoin()
    {
        totalCoins += 1;
        coinsText.text = "Coins: "+ CollectingCoins.coin.ToString();
        totalCoinsText.text = "Total Coins: " + totalCoins.ToString();
        PlayerPrefs.SetInt("totalCoins", totalCoins);
    }

}
