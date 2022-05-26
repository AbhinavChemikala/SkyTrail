using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeUI : MonoBehaviour
{
    public GameObject ThiefUI;
    public GameObject PlayerUI;
    public GameObject AngelUI;
    public GameObject RunnerUI;
    
    // Start is called before the first frame update
    void Start()
    {
        if (Shop.thiefUI)
        {
            ThiefUI.SetActive(true);
        }
        else if (Shop.luckyUI)
        {
            AngelUI.SetActive(true);
        }
        else if (Shop.runnerUI)
        {
            RunnerUI.SetActive(true);
        }
        else
        {
            PlayerUI.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
