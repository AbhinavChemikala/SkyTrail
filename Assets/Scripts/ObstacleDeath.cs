using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObstacleDeath : MonoBehaviour
{
    public GameObject LevelMusic;
    
    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Player" || Col.gameObject.tag == "Angel" || Col.gameObject.tag == "Thief" || Col.gameObject.tag == "Runner")
        {
            Destroy(LevelMusic);
            Time.timeScale = 0;
            Destroy(Col.gameObject);
        }
    }
    
}
