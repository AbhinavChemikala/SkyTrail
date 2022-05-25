using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject player;
    public GameObject bladePrefabs;
    private Vector3 spawnObstaclePosition;
    private Vector3 playerPos;
    private Vector3 playerDirection;
    private Quaternion playerRotation;
    float timer=0;

    private void Update()
    {
        playerPos = player.transform.position;
        playerDirection = player.transform.forward;
        playerRotation = player.transform.rotation;
        timer += Time.deltaTime;

        if(timer>3f){
            spawnObstacle();
            timer = 0;
        }    
        
    }

    void spawnObstacle()
    {
        float spawnDistance = 10;
        playerPos.y += 1;
        Vector3 spawnPos = playerPos + playerDirection*spawnDistance;
 
        Instantiate(bladePrefabs, spawnPos, playerRotation );
        
    }
    
 

    
}
