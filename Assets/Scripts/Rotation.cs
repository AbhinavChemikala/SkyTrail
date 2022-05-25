using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Coin" )
        {
            transform.Rotate(0, 1, 0, Space.World);
        }
        if (gameObject.tag == "Blade" )
        {
            transform.Rotate(0, 1, 0, Space.World);
            
        }
    }
}
