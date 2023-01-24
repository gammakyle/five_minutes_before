using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class timerscript : MonoBehaviour
{
    public int people_ticker = 0;
    public int take_ticker = 0;
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public TextMeshPro TextMeshProObject;
    public GameObject TextPanel;
    public GameObject TextPanel1;
    public GameObject TextPanel2;
    public GameObject finbutton;





    private void Start()
    {
        timerIsRunning = true;
    }
    void Update()
    {
        TextMeshProUGUI TextMeshProLable1 = TextPanel2.GetComponent<TextMeshProUGUI>();
        TextMeshProLable1.text = take_ticker.ToString() + "/5";
        TextMeshProUGUI TextMeshProLable2 = TextPanel1.GetComponent<TextMeshProUGUI>();
        TextMeshProLable2.text = people_ticker.ToString() + "/5";


        if (people_ticker == 5 && take_ticker == 5)
        {
            finbutton.SetActive(true);
        }


        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                PlayerPrefs.SetInt("achivement_9", 1);
                PlayerPrefs.SetInt("type_of_final", 9);
                SceneManager.LoadScene("final scene");
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        TextMeshProUGUI TextMeshProLable = TextPanel.GetComponent<TextMeshProUGUI>();
        TextMeshProLable.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
