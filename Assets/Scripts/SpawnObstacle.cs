using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject player;
    public GameObject[] bladePrefabs;
    private Vector3 spawnObstaclePosition;

    private void Update()
    {
        float distanceTohorizon = Vector3.Distance(player.gameObject.transform.position, spawnObstaclePosition);
        //spawnObstacle();
        Invoke("spawnObstacle",3f);
        
    }

    void spawnObstacle()
    {
        spawnObstaclePosition = player.gameObject.transform.position;
        spawnObstaclePosition.z += 4;
        spawnObstaclePosition.y += 1;
        Instantiate(bladePrefabs[(Random.Range(0, bladePrefabs.Length))], spawnObstaclePosition, quaternion.identity);
        CancelInvoke(); 
    }
}
