using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene("Game Over");
            
        }
    }
}
