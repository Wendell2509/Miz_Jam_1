using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopTheTimer : MonoBehaviour
{
    public bool setBoolTimer;

    private float t;
    public static float timeBeforeStart;

    private void Start()
    {
    }

    private void Update()
    {
        t = Time.time;
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        timeBeforeStart = t;
        timerManager.timeRunning = setBoolTimer;
        gameObject.SetActive(false);
    }
}