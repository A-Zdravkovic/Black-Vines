using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNew : MonoBehaviour
{

    public int HP; //health of our player
    public int power; //power of our player, how much damage they do
    public bool takeDamage; //tick box for our player to take damage

    // Update is called once per frame
    void Update()
    {
        if (takeDamage == true) //1 = means you are setting as true 2 == means you are asking if something is true
        {
            TakeDamage(power); //calls take damage function
            takeDamage = false;
        }

    }


    //TODO
    //create function for player to take damge
    //reduce the players health
    // pass though a certain ammount of damage

    public void TakeDamage(int damage)
    {
        HP -= damage; //reduce health
        if (HP <= 0) 
        {
            Destroy(gameObject); // destroyes itself
            // gameObject with a lowercase g and capital O means it referances itself
        }
    }

}
