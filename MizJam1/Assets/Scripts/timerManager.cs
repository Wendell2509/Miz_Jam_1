using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerManager : MonoBehaviour
{
    public Text speedRunTimerTxt;
    public float startTime;
    public float currentTime;
    public static bool timeRunning;
    public static float t;

    private void Start()
    {
        currentTime = startTime;

        timeRunning = false;
    }

    private void Update()
    {
        if (timeRunning)
        {
            t = Time.time - stopTheTimer.timeBeforeStart;

            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            speedRunTimerTxt.text = "Time: " + minutes + ":" + seconds;
        }
    }
}