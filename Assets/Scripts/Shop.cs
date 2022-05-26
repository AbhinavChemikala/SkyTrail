using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Shop : MonoBehaviour
{
    private int ShopCoins;
    public TextMeshProUGUI totalCoinsText;
    public TextMeshProUGUI thiefBoughtText;
    public TextMeshProUGUI runnerBoughtText;
    public TextMeshProUGUI luckyBoughtText;




    private int thief = 1000;
    private int runner = 2500;
    private int lucky = 5000;
    
    public static bool thiefChar = false;
    public static bool runnerChar = false;
    public static bool luckyChar = false;
    
    public static bool thiefBought = false;
    public static bool runnerBought = false;
    public static bool luckyBought = false;

    void Start()
    {
        ScoreManager.totalCoins = PlayerPrefs.GetInt("totalCoins", 0);
        ShopCoins = ScoreManager.totalCoins;
        totalCoinsText.text = " Coins: " + ShopCoins.ToString();

    }

    public void ThiefButton()
    {
        if (ShopCoins >= thief && thiefBought == false)
        {
            ShopCoins -= thief;
            totalCoinsText.text = " Coins: " + ShopCoins.ToString();
            PlayerPrefs.SetInt("totalCoins", ShopCoins);
            thiefChar = true;
            thiefBought = true;
            thiefBoughtText.text = "Bought";
            Debug.Log("Buy");
        }
    }
    public void RunnerButton()
    {
        if (ShopCoins >= runner  && runnerBought == false)
        {
            ShopCoins -= runner;
            totalCoinsText.text = " Coins: " + ShopCoins.ToString();
            PlayerPrefs.SetInt("totalCoins", ShopCoins);
            runnerChar = true;
            runnerBought = true;
            runnerBoughtText.text = "Bought";


            Debug.Log("Buy");

        }
    }
    public void LuckyButton()
    {
        if (ShopCoins >= lucky && luckyBought == false)
        {
            ShopCoins -= lucky;
            totalCoinsText.text = " Coins: " + ShopCoins.ToString();
            PlayerPrefs.SetInt("totalCoins", ShopCoins);
            luckyChar = true;
            luckyBought = true;
            Debug.Log("Buy");
            luckyBoughtText.text = "Bought";
        }
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("SkyTrails");
    }
    
    public void MainMenuButton()
    {
        SceneManager.LoadScene("Main Menu");

    }
    
}
