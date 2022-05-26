using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    private bool turnLeft, turnRight;
    //public Text distancemoved;
    public float speed = 7.0f;
    //float distanceunit = 0;
    private CharacterController myCharacterController;
    public static int numberOfCoins;

    // Start is called before the first frame update
    void Start()
    {
        myCharacterController = GetComponent<CharacterController>();
        numberOfCoins = 0;
        //InvokeRepeating("distance",0,1 / speed);
    }

    // Update is called once per frame
    void Update()
    {
        turnLeft = Input.GetKeyDown(KeyCode.A);
        turnRight = Input.GetKeyDown(KeyCode.D);

        if (turnLeft)
            transform.Rotate(new Vector3(0f, -90f, 0f));
        else if (turnRight)
            transform.Rotate(new Vector3(0f, 90f, 0f));

        myCharacterController.SimpleMove(new Vector3(0f, 0f, 0f));
        myCharacterController.Move(transform.forward * speed * Time.deltaTime);
        
        
        
       
    }

    void distance()
    { 
        //distanceunit = distanceunit + 1;
        //distancemoved.text = distanceunit.ToString();
    }
}