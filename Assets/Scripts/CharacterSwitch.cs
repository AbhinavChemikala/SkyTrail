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
