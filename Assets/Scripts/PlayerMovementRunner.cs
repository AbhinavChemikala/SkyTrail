using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementRunner : MonoBehaviour
{
    private bool turnLeft, turnRight;
    private float speed;
    private CharacterController myCharacterController;
    public static int numberOfCoins;
    public AudioSource runPower;

    // Start is called before the first frame update
    void Start()
    {
        myCharacterController = GetComponent<CharacterController>();
        numberOfCoins = 0;
        speed = 7.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            speed = 14.0f;
            runPower.Play();
        }

        turnLeft = Input.GetKeyDown(KeyCode.A);
        turnRight = Input.GetKeyDown(KeyCode.D);

        if (turnLeft)
            transform.Rotate(new Vector3(0f, -90f, 0f));
        else if (turnRight)
            transform.Rotate(new Vector3(0f, 90f, 0f));

        myCharacterController.SimpleMove(new Vector3(0f, 0f, 0f));
        myCharacterController.Move(transform.forward * speed * Time.deltaTime);
    }
}