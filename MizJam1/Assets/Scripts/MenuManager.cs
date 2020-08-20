using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject[] Menus;//0 Main Menu//1 Play(Gameplay)//2 Settings//3Credits
    public int MenuActive;

    private void Start()
    {
        // MenuActive = 0;
    }

    private void Update()
    {
        for (int i = 0; i < Menus.Length; i++)
        {
            if (i == MenuActive)
            {
                Menus[i].SetActive(true);
            } else
            {
                Menus[i].SetActive(false);
            }
        }

        ReloadScene();
    }

    private void ReloadScene()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void GoToMenu()
    {
        MenuActive = 0;
    }

    public void GoPlay()
    {
        MenuActive = 1;
    }

    public void GoToSettings()
    {
        MenuActive = 2;
    }

    public void GoToCredits()
    {
        MenuActive = 3;
    }

    public void Quit()
    {
        Application.Quit();
    }
}