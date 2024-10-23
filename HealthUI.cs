using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public PlayerStats playerStats;

    // Update is called once per frame
    void Update()
    {
        if (playerStats.currentHP == 2)
        {
            Destroy(GameObject.Find("Heart3"));
        }

        if (playerStats.currentHP == 1)
        {
            Destroy(GameObject.Find("Heart3"));
            Destroy(GameObject.Find("Heart2"));
        }

        if (playerStats.currentHP <= 0)
        {
            Destroy(GameObject.Find("Heart3"));
            Destroy(GameObject.Find("Heart2"));
            Destroy(GameObject.Find("Heart1"));
        }
    }
}
