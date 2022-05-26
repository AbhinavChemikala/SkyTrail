using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField]public Transform player;
    [SerializeField]public Transform RespawnTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RespawnTrigger")
        {
            player.transform.position = RespawnTrigger.transform.position;
            Debug.Log("Respawn");
        }
        
        
    }
}
