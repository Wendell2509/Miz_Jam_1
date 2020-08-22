using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerManager : MonoBehaviour
{
    public Text speedRunTimerTxt;
    public static bool timeRunning;
    public static float totalTime;
    public static string levelTimer;

    private void Start()
    {
        timeRunning = false;
    }

    private void Update()
    {
        if (timeRunning)
        {
            totalTime = Time.time - stopTheTimer.timeBeforeStart;

            string minutes = ((int)totalTime / 60).ToString();
            string seconds = (totalTime % 60).ToString("f2");

            levelTimer = "Time: " + minutes + ":" + seconds;
            speedRunTimerTxt.text = "Time: " + minutes + ":" + seconds;
        }
    }
}