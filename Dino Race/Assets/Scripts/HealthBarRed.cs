using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarRed : MonoBehaviour
{
    public Slider slider;

    private PlayerScriptTop playerScript;

    private void Awake()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScriptTop>();
    }

    private void Update()
    {
        slider.value = playerScript.HP;
    }

    public void SetMaxHealth(float maxHP)
    {
        slider.maxValue = maxHP;
        slider.value = maxHP;
    }

    public void SetHealth(float currentHP)
    {
        slider.value = currentHP;
    }
}