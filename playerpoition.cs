using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerpoition : MonoBehaviour
{
    // Start is called before the first frame update

    private Slider positionSlider;
    public PlayerMovment playerMovement;
  
    void Start()
    {
        positionSlider = GetComponent<Slider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPosition = playerMovement.transform.position;
        positionSlider.value = Mathf.Clamp(playerPosition.x, positionSlider.minValue, positionSlider.maxValue);
    }

}
