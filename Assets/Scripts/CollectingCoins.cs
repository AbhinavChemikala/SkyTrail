using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectingCoins : MonoBehaviour
{
    public GameObject coins;
    public AudioClip coinSound;
    public static int coin = 0;
    
    // Start is called before the first frame update
    public void Start()
    {
        
    }

    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Coin")
        {
            coin++;
            ScoreManager.instance.addCoin();
            Debug.Log(coin);
            Col.gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(coinSound, transform.position,1.56f);
            Invoke(nameof(ActiveCoin),5f);
            //StartCoroutine(HideObject());
        }

        
    }
    
        
        
    

    public void ActiveCoin()
    {
        Debug.Log("Active coin");

        coins.SetActive(true);
    }


 

    
}
