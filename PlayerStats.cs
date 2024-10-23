using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int spritesCollected;
    public int goldCollected;
    public UiManager uiManager;
    public GoldManager goldManager;
    public int power;
    public bool takeDamage;
    public int maxHP;
    public int currentHP;

    void Start()
    {
        currentHP = maxHP;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sprite"))
        {
            spritesCollected += 1;
            Destroy(collision.gameObject);
            uiManager.UpdateSpritesCollected(spritesCollected);
        }
    }

    //public void GoldButtonOnClick()
    //{
      //  goldCollected += 1;
     //   Debug.Log("button clicked, gold got");
     //   goldManager.UpdateGoldCollected(goldCollected);
  //  }


    void Update()
    {
        if (takeDamage == true) 
        {
            TakeDamage(power); 
            takeDamage = false;
        }

        if (currentHP <= 0)
        {
            Destroy(this.gameObject); // destroyes itself


        }
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage; 
        if (currentHP <= 0)
        {
            Destroy(this.gameObject); // destroyes itself

        }
    }

}
