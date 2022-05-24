using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    void Update()
    {
        if (this.transform.position.y < -0.1)
        {
            Debug.Log("Fallen");
        }
    }
}
