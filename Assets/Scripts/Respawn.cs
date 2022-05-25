using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField]public Transform player;
    [SerializeField]public Transform RespawnTrigger;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            player.transform.position = RespawnTrigger.transform.position;
            Debug.Log("Respawn");
        }
    }
    
    
}
