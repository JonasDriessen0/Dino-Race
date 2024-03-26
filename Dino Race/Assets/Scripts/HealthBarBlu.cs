using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBlu : MonoBehaviour
{
    public Slider slider;

    private PlayerScript playerScript;

    private void Awake()
    {
        playerScript = GameObject.FindGameObjectWithTag("PlayerBlu").GetComponent<PlayerScript>();
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