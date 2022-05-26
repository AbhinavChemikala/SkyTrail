using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour
{

    public GameObject thiefObj;
    public GameObject runnerObj;
    public GameObject luckyObj;
    public GameObject maincharObj;

    void Start()
    {
        Shop.thiefBought = (PlayerPrefs.GetInt("thiefBought") != 0);
        Shop.runnerBought = (PlayerPrefs.GetInt("RunnerBought") != 0);
        Shop.luckyBought = (PlayerPrefs.GetInt("luckyBought") != 0);
        Shop.thiefChar = (PlayerPrefs.GetInt("thiefChar") != 0);
        Shop.runnerChar = (PlayerPrefs.GetInt("runnerChar") != 0);
        Shop.luckyChar = (PlayerPrefs.GetInt("luckyChar") != 0);
        
        if (Shop.thiefChar)
        {
            thiefObj.SetActive(true);
            runnerObj.SetActive(false);
            luckyObj.SetActive(false);
            maincharObj.SetActive(false);
            Shop.thiefChar = false;
        }
        else if (Shop.runnerChar)
        {
            thiefObj.SetActive(false);
            runnerObj.SetActive(true);
            luckyObj.SetActive(false);
            maincharObj.SetActive(false);
            Shop.runnerChar = false;
        }
        else if (Shop.luckyChar)
        {
            thiefObj.SetActive(false);
            runnerObj.SetActive(false);
            luckyObj.SetActive(true);
            maincharObj.SetActive(false);
            Shop.luckyChar = false;
        }
        else
        {
            thiefObj.SetActive(false);
            runnerObj.SetActive(false);
            luckyObj.SetActive(false);
            maincharObj.SetActive(true);
        }

        
    }

}
