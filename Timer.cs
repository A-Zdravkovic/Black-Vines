using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60;
    public PlayerStats playerStats;
    public bool timerIsRunning = false;
    public TextMeshProUGUI timerTxt;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        timerTxt = gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                updateTimer(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                GetComponent<PlayerStats>();
                playerStats.currentHP = 0;
                DestroyObject(GetComponent<Player>());
            }
        }

        if (playerStats.currentHP <= 0)
        {
            timerIsRunning = false;
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        //float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime); //% 60);

        //timerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
        timerTxt.text = string.Format("{00}", seconds);

        if (currentTime <= 11)
        {
            timerTxt.color = Color.red;
        }

    }
}