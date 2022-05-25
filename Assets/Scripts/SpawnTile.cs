using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTile : MonoBehaviour
{
    public GameObject tileToSpawn;
    public GameObject coinToSpawn;

    public GameObject referenceObject;
    public GameObject coinreferenceObject;

    //public GameObject deathTriggerToSpawn;
    //public GameObject deathTriggerReference;

    //public GameObject obstacleToSpawn;
    //public GameObject obstaclereference;
    
    public float timeOffset = 0.4f;
    public float timeOffsetCoin = 0.8f;
    public float distanceBetweenTiles = 5.0F;
    public float distanceBetweenCoin = 5.0F;
    //public float distanceBetweenObstacle = 5.0f;

    public float randomValue = 0.8f;
    private Vector3 previousTilePosition;
    private Vector3 previousCoinPosition;
    //private Vector3 previousObstaclePosition;
    //private Vector3 previosDeathTriggerPosition;
    private float startTime;
    private Vector3 direction, mainDirection = new Vector3(0, 0, 1), otherDirection = new Vector3(1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        previousTilePosition = referenceObject.transform.position;
        previousCoinPosition = referenceObject.transform.position;
        //previosDeathTriggerPosition = referenceObject.transform.position;
        //previousObstaclePosition = referenceObject.transform.position;

       // previosDeathTriggerPosition.y -= 2;
        previousCoinPosition.y += 1;
        //previousObstaclePosition.y += 1;
        
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
            //previousObstaclePosition.x = Random.Range(1, 10);
            //Vector3 spawnposObstacle = previousCoinPosition + distanceBetweenObstacle * direction;
            //spawnposObstacle.x += Random.Range(1, 10);
            startTime = Time.time;
            Instantiate(tileToSpawn, spawnPos, Quaternion.Euler(0, 0, 0));
            previousTilePosition = spawnPos;

           // Instantiate(deathTriggerToSpawn, spawnPos, Quaternion.Euler(0, 0, 0));
            //previosDeathTriggerPosition = spawnPos;
            
            Instantiate(coinToSpawn, spawnposCoin, Quaternion.Euler(0, 0, 0));
            previousCoinPosition = spawnposCoin;
            
            //Instantiate(obstacleToSpawn, spawnposObstacle, Quaternion.Euler(0, 0, 0));
            //previousObstaclePosition = spawnposObstacle;
        }
    }
}