using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpike : MonoBehaviour
{
    public int spikeOuch = 1;
    public int spikeDMG;
    PlayerStats playerStats;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("you touched a thing!");

        if (collision.CompareTag("Player"))
        {
            playerStats = collision.GetComponent<PlayerStats>();
            playerStats.TakeDamage(spikeOuch);
            //playerStats.CurrentHP(spikeDMG);
        }
    }


}

