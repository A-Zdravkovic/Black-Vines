using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//need to remember the name 'PlayerOld' must be the same as file name
public class PlayerOld : MonoBehaviour 
{
    // Start is called before the first frame update and only called at the first frame
    void Start() //brackets are for passing dating through that section of the script
    {
        //this debug prints in the console at the first frame
        Debug.Log("Start Game - BlackVines");

        // transform with a lowercase tells the scrip to look at the componants above this scrips componant
        transform.position = new Vector3(0, 0, 0);    
    }

    // Update is called once per frame, every frame
    void Update()
    {
        //this is saying that when the W key is pressed it will trigger the script inside the if statment
        if (Input.GetKeyDown(KeyCode.W)) // W is the key, can change this to any key or button such as "Space" or "Alpha 1"
        {
            //the += means that it will add the script to the pre-existing position
            transform.position += new Vector3(0, 1, 0);

            Debug.Log("W key has been pressed");
        }

        //moves the player down
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);

            Debug.Log("S key has been pressed");
        }

        //moves player to left
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);

            Debug.Log("A key has been pressed");
        }

        //moves player to right
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);

            Debug.Log("D key has been pressed");
        }


    }
}
