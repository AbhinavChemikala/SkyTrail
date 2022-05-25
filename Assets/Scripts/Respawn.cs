using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject player;
    private Vector3 playerPosition;
    // Start is called before the first frame update
    void Start()
    {
         playerPosition = player.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerPosition.y >= 2.26f)
        {
            playerPosition = player.gameObject.transform.position;
            Debug.Log(playerPosition);
        }
    }

    void Respawns()
    {

    }
}
