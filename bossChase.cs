using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossChase : MonoBehaviour
{
    public Transform bossTarget;
    public float bossSpeed;
    public PlayerStats playerStats;
    public float baseSpeed; // The base speed of the boss
    public float maxSpeed; // The maximum speed the boss can reach
    public float minDistance; // The minimum distance to reach max speed
    public float maxDistance; // The maximum distance to reach min speed


    private float currentSpeed; // The current speed of the boss
    private Transform playerTransform; // Reference to the player's transform
    private float fixedYPosition; // The fixed Y position for the boss


    void Start()
    {
        // Find the player transform by tag (make sure the player has the "Player" tag)
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        fixedYPosition = transform.position.y;
    }
    // Update is called once per frame
    void Update()
    {
        if (playerTransform == null)
        {
            playerTransform = GameObject.FindGameObjectWithTag("Player")?.transform;
            return; // Exit if still null
        }

        float distance = Vector3.Distance(transform.position, playerTransform.position);

        // Adjust the speed based on the distance
        if (distance > maxDistance)
        {
            currentSpeed = maxSpeed; // Maximum speed when far away
        }
        else if (distance < minDistance)
        {
            currentSpeed = baseSpeed; // Base speed when too close
        }
        else
        {
            // Calculate speed between baseSpeed and maxSpeed
            float speedFactor = Mathf.InverseLerp(maxDistance, minDistance, distance);
            currentSpeed = Mathf.Lerp(maxSpeed, baseSpeed, speedFactor);
        }

        // Move the boss towards the player while maintaining fixed Y position
        Vector3 targetPosition = new Vector3(playerTransform.position.x, fixedYPosition, playerTransform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, currentSpeed * Time.deltaTime);

        // Optional Debugging
        //Debug.Log($"Distance: {distance}, Current Speed: {currentSpeed}");
    }

    // Update is called once per frame
    //void Update()
    //{
    //transform.position = Vector3.MoveTowards(transform.position, bossTarget.position, bossSpeed * Time.deltaTime);
    //}



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("boss touched you");

        if (collision.CompareTag("Player"))
        {
            playerStats = collision.GetComponent<PlayerStats>();
            playerStats.currentHP = 0;
            Debug.Log("oh no ouchy uch you diedddd");
            Destroy(collision.gameObject);
        }
    }
}
