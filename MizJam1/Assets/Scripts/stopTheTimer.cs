using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class stopTheTimer : MonoBehaviour
{
    public bool setBoolTimer;

    private float t;
    public static float timeBeforeStart;
    public Collider2D coll;

    public enum Levels
    {
        L1,
        L2,
        L3
    }

    public Levels levels;

    private void Start()
    {
        coll = GetComponent<Collider2D>();
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
            coll.enabled = false;

            if (!setBoolTimer)
            {
                StartCoroutine(GoTOMenu());

                switch (levels)
                {
                    case Levels.L1:

                        if (PlayerPrefs.GetFloat("R1f") > timerManager.totalTime || PlayerPrefs.GetFloat("R1f") == 0)
                        {
                            print("record1: " + PlayerPrefs.GetFloat("R1f") + " > " + timerManager.totalTime);
                            Debug.Log("New record level 1: " + timerManager.levelTimer);
                            PlayerPrefs.SetString("record1", timerManager.levelTimer);
                            PlayerPrefs.SetFloat("R1f", timerManager.totalTime);
                        } else
                        {
                            print("too slow record still " + PlayerPrefs.GetString("record1"));
                        }
                        break;

                    case Levels.L2:
                        if (PlayerPrefs.GetFloat("R2f") > timerManager.totalTime || PlayerPrefs.GetFloat("R2f") == 0)
                        {
                            print("record2: " + PlayerPrefs.GetFloat("R2f") + " > " + timerManager.totalTime);
                            Debug.Log("New record level 2: " + timerManager.levelTimer);
                            PlayerPrefs.SetString("record2", timerManager.levelTimer);
                            PlayerPrefs.SetFloat("R2f", timerManager.totalTime);
                        } else
                        {
                            print("too slow record still " + PlayerPrefs.GetString("record2"));
                        }
                        break;

                    case Levels.L3:
                        if (PlayerPrefs.GetFloat("R3f") > timerManager.totalTime || PlayerPrefs.GetFloat("R3f") == 0)
                        {
                            print("record3: " + PlayerPrefs.GetFloat("R3f") + " > " + timerManager.totalTime);
                            Debug.Log("New record level 3: " + timerManager.levelTimer);
                            PlayerPrefs.SetString("record3", timerManager.levelTimer);
                            PlayerPrefs.SetFloat("R3f", timerManager.totalTime);
                        } else
                        {
                            print("too slow record still " + PlayerPrefs.GetString("record3"));
                        }
                        break;

                    default:
                        print("out of range");
                        break;
                }
            }
        }
    }

    private IEnumerator GoTOMenu()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("menu");
    }
}