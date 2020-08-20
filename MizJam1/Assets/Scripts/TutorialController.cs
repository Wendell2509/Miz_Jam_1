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
            tutorialDone = true;
        }

        tutorialPanel.SetActive(!tutorialDone);
    }
}