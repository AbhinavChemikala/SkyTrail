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
    
    public TextMeshProUGUI thiefEquipText;
    public TextMeshProUGUI runnerEquipText;
    public TextMeshProUGUI luckyEquipText;




    private int thief = 1000;
    private int runner = 2500;
    private int lucky = 5000;
    
    public static bool thiefChar = false;
    public static bool runnerChar = false;
    public static bool luckyChar = false;
    
    public static bool thiefBought = false;
    public static bool runnerBought = false;
    public static bool luckyBought = false;

    public static bool thiefUI = false;
    public static bool runnerUI = false;
    public static bool luckyUI = false;

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
            thiefBought = true;
            thiefBoughtText.text = "Bought";
            PlayerPrefs.SetInt("thiefBought",(thiefBought ? 1 : 0));
            thiefUI = true;
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
            runnerBought = true;
            runnerBoughtText.text = "Bought";
            PlayerPrefs.SetInt("RunnerBought",(runnerBought ? 1 : 0));
            runnerUI = true;

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
            PlayerPrefs.SetInt("luckyBought",(luckyBought ? 1 : 0));

            luckyBought = true;
            luckyUI = true;
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

    public void ThiefEquipbutton()
    {
        if (thiefBought)
        {
            thiefChar = true;
            thiefEquipText.text = "Equipped";
            PlayerPrefs.SetInt("thiefChar",(thiefChar ? 1 : 0));
        }
        
    }
    public void RunnerEquipbutton()
    {
        if (runnerBought)
        {
            runnerChar = true;
            runnerEquipText.text = "Equipped";
            PlayerPrefs.SetInt("runnerChar",(runnerChar ? 1 : 0));

        }
    }
    public void AngelEquipbutton()
    {
        if (luckyBought)
        {
            luckyChar = true;
            luckyEquipText.text = "Equipped";
            PlayerPrefs.SetInt("luckyChar",(luckyChar ? 1 : 0));

        }
    }
}
