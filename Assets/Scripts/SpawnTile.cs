using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class SpawnTile : MonoBehaviour
{
    public GameObject tileToSpawn;
    public GameObject coinToSpawn;

    public GameObject referenceObject;
    public GameObject coinreferenceObject;
    
    public float timeOffset = 0.4f;
    public float timeOffsetCoin = 0.8f;
    public float distanceBetweenTiles = 5.0F;
    public float distanceBetweenCoin = 5.0F;

    public float randomValue = 0.8f;
    private Vector3 previousTilePosition;
    private Vector3 previousCoinPosition;

    private float startTime;
    private Vector3 direction, mainDirection = new Vector3(0, 0, 1), otherDirection = new Vector3(1, 0, 0);


    void Start()
    {
        previousTilePosition = referenceObject.transform.position;
        previousCoinPosition = referenceObject.transform.position;
        previousCoinPosition.y += 1;
        startTime = Time.time;
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime > timeOffset )
        {
            if (Random.value < randomValue)
                direction = mainDirection;
            else
            {
                Vector3 temp = direction;
                direction = otherDirection;
                mainDirection = direction;
                otherDirection = temp;
            }
            Vector3 spawnPos = previousTilePosition + distanceBetweenTiles * direction;
            Vector3 spawnposCoin = previousCoinPosition + distanceBetweenCoin * direction;
            
            startTime = Time.time;
            Instantiate(tileToSpawn, spawnPos, Quaternion.Euler(0, 0, 0));
            previousTilePosition = spawnPos;

            Instantiate(coinToSpawn, spawnposCoin, Quaternion.Euler(0, 0, 0));
            previousCoinPosition = spawnposCoin;
        }
    }
}