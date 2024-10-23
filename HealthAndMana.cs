using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class HealthAndMana : MonoBehaviour
{
    public Image healthBar;
    public int maxHP;
    public int currentHP;

    public Image manaBar;
    public int maxMP;
    public int currentMP;

    private void Start()
    {
        currentHP = maxHP;
        currentMP = maxMP;
    }

    private void UpdateHealth()
    {
        float fillAmount = (float)currentHP / (float)maxHP;
        healthBar.fillAmount = fillAmount;
    }

    private void UpdateMana()
    {
        float fillAmount = (float)currentMP / (float)maxMP;
        manaBar.fillAmount = fillAmount;
    }

    private void Update()
    {
        UpdateHealth();
        UpdateMana();
    }
}


