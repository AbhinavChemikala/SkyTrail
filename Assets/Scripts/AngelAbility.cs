using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngelAbility : MonoBehaviour
{
    public static bool InvisAbil = false;
    private bool onCooldown = false;
    private float cooldownTime = 15.0f;
    private float cooldownTimer = 0.0f;

    public AudioSource Ability;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            InvisibleAbility();
            Ability.Play();
        }
        if (onCooldown)
        {
            ApplyCooldown();
        }
    }

    void InvisibleAbility()
    {
        if (onCooldown)
        {
            //user clicked spell while in use here
        }
        else
        {
            onCooldown = true;
            InvisAbil = true;
            cooldownTimer = cooldownTime;

        }
    }
    
    void ApplyCooldown()
    {
        cooldownTimer -= Time.deltaTime;

        if (cooldownTimer < 0.0f)
        {
            onCooldown = false;
            InvisAbil = false;
            
        }
        else
        {
            
        }
    }
}
