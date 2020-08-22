using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopTheTimer : MonoBehaviour
{
    public bool setBoolTimer;

    private float t;
    public static float timeBeforeStart;

    public enum Levels
    {
        L1,
        L2,
        L3
    }

    public Levels levels;

    private void Start()
    {
    }

    private void Update()
    {
        t = Time.time;
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.name == "Player")
        {
            timeBeforeStart = t;
            timerManager.timeRunning = setBoolTimer;
            gameObject.SetActive(false);

            switch (levels)
            {
                case Levels.L1:

                    timerRecordManager.record1 = timerManager.levelTimer;
                    break;

                case Levels.L2:
                    timerRecordManager.record2 = timerManager.levelTimer;
                    break;

                case Levels.L3:
                    timerRecordManager.record3 = timerManager.levelTimer;
                    break;

                default:
                    print("out of range");
                    break;
            }
        }
    }
}