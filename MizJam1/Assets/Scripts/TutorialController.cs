using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    public bool tutorialDone;
    public GameObject tutorialPanel;

    private void Start()
    {
        tutorialDone = false;
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0 || Input.GetKey(PlayerController.runKeyGlobal))
        {
            StartCoroutine(DesactivatedTutorial());
        }

        tutorialPanel.SetActive(!tutorialDone);
    }

    private IEnumerator DesactivatedTutorial()
    {
        yield return new WaitForSecondsRealtime(5f);
        tutorialDone = true;
    }
}