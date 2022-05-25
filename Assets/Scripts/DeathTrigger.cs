using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    private GameObject LevelMusic;
    void Update()
    {
        if (this.transform.position.y < -0.1)
        {
            Debug.Log("Fallen");
            LevelMusic = GameObject.Find("LevelMusic");
            Destroy(LevelMusic);
            Time.timeScale = 0;
        }
    }
}
