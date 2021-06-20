using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class TimerCountdown : MonoBehaviour
{
    Text timeText;
    float timer = 300;
    [SerializeField]
    GameObject gameOverGO;
    bool gameOver;


    private void Start()
    {
        timeText = GetComponent<Text>();
    }
    void Update()
    {
        timer = timer - Time.deltaTime;
        var item = Mathf.RoundToInt(timer);
        string minutes = TimeSpan.FromSeconds(item).Minutes.ToString();
        string seconds = TimeSpan.FromSeconds(item).Seconds.ToString();
        timeText.text = minutes + ":" + seconds;
        if (timer <= 0)
        {
            timeText.text = "0";
            gameOverGO.GetComponent<Text>().text = "Game Over";
            gameOver = true;
        }
        if (Input.GetKeyDown(KeyCode.Return) && gameOver)
        {
            SceneManager.LoadScene(1);
        }
    }
}
