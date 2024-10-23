using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pit : MonoBehaviour
{

    public PlayerStats playerStats;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            playerStats = collision.GetComponent<PlayerStats>();
            playerStats.currentHP = 0;
            Debug.Log("fell in hole and died");
            Destroy(collision.gameObject);
        }
    }
}

