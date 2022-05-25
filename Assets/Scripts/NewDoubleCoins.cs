using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewDoubleCoins : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    private int scoreValue;
    private bool doubleCoins = false;
    //private int doubleScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            doubleCoins = true;
    
        }
    }

    private void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Coin" && doubleCoins == true)
        {
            CollectingCoins.coin += 1;
            StartCoroutine("Stop2X");
        }
    }

    private IEnumerator Stop2X()
    {
        yield return new WaitForSeconds(15);
        doubleCoins = false;
    }

}
