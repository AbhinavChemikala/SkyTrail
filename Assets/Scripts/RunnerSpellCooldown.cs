using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RunnerSpellCooldown : MonoBehaviour
{
   
    [SerializeField]
    private Image imageCooldown;
    [SerializeField]
    private TMP_Text textCooldown;

    //variables for cooldown timer
    private bool onCooldown = false;
    private float cooldownTime = 15.0f;
    private float cooldownTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        textCooldown.gameObject.SetActive(false);
        imageCooldown.fillAmount = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            UseSpellRun();
        }
        if (onCooldown)
        {
            ApplyCooldown();
        }
    }

    public void UseSpellRun()
    {
        if (onCooldown)
        {
            //user clicked spell while in use here
        }
        else
        {
            onCooldown = true;
            textCooldown.gameObject.SetActive(true);
            cooldownTimer = cooldownTime;

        }
    }

    void ApplyCooldown()
    {
        cooldownTimer -= Time.deltaTime;

        if (cooldownTimer < 0.0f)
        {
            onCooldown = false;
            textCooldown.gameObject.SetActive(false);
            imageCooldown.fillAmount = 0.0f;
        }
        else
        {
            textCooldown.text = Mathf.RoundToInt(cooldownTimer).ToString();
            imageCooldown.fillAmount = cooldownTimer / cooldownTime;
        }
    }
}