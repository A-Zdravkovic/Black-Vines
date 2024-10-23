using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int enemyPower; // how much dmg enemy has
    public PlayerNew newPlayer;
    public bool hurtPlayer;

    // Update is called once per frame
    void Update()
    {
        if (hurtPlayer == true)
        { 
            AttackPlayer();
            hurtPlayer = false;
        }
        

    }

    void AttackPlayer() //attacks player
    {

        //TODO
        // sent enemypower int to the players takedamage function
        newPlayer.TakeDamage(enemyPower);

    }
}
