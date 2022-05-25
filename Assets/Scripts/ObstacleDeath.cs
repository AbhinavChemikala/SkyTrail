using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleDeath : MonoBehaviour
{
    public GameObject LevelMusic;
    
    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Player" || Col.gameObject.tag == "Angel" || Col.gameObject.tag == "Thief" || Col.gameObject.tag == "Runner")
        {
            Destroy(LevelMusic);
            SceneManager.LoadScene("Game Over");
            Destroy(Col.gameObject);
        }
    }
    
}
