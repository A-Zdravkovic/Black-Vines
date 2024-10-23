using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    private float startPos, length;
    public GameObject cam;
    public float parallaxEffect;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x; // Get the width of the sprite
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = cam.transform.position.x * parallaxEffect; // Use multiplication for distance calculation
        float movement = cam.transform.position.x * (1 - parallaxEffect); // Use multiplication for movement calculation

        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        // Check if the camera has moved beyond the current background
        if (movement > startPos + length)
        {
            startPos += length;
        }
        else if (movement < startPos - length)
        {
            startPos -= length;
        }
    }
}
