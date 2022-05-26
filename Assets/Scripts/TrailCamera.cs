using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailCamera : MonoBehaviour
{
    public Transform target;
    public float trailDistance = 5.0f;
    public float heightOffset = 3.0f;
    public float cameraDelay = 0.02f;
    [SerializeField] Transform thiefObj;
    [SerializeField] Transform runnerObj;
    [SerializeField] Transform luckyObj;
    [SerializeField] Transform maincharObj;
    
    private void Start()
    {
        Shop.thiefChar = (PlayerPrefs.GetInt("thiefChar") != 0);
        Shop.runnerChar = (PlayerPrefs.GetInt("runnerChar") != 0);
        Shop.luckyChar = (PlayerPrefs.GetInt("luckyChar") != 0);
        if (Shop.thiefChar)
        {
            target = thiefObj;
        }
        else if (Shop.runnerChar)
        {
            target = runnerObj;

        }
        else if (Shop.luckyChar)
        {
            target = luckyObj;

        }
        else
        {
            target = maincharObj;

        }
    }

    void Update()
    {
        Vector3 followPos = target.position - target.forward * trailDistance;

        followPos.y += heightOffset;
        transform.position += (followPos - transform.position) * cameraDelay;

        transform.LookAt(target.transform);
    }
} 