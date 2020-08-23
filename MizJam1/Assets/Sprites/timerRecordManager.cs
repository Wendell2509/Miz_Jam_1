using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class timerRecordManager : MonoBehaviour
{
    public Text recordL1, recordL2, recordL3;

    private void Start()
    {
    }

    private void Update()
    {
        recordL1.text = PlayerPrefs.GetString("record1");
        recordL2.text = PlayerPrefs.GetString("record2");
        recordL3.text = PlayerPrefs.GetString("record3");

        if (PlayerPrefs.GetFloat("R1f") == 0f)
        {
            recordL1.text = "-------";
        }

        if (PlayerPrefs.GetFloat("R2f") == 0f)
        {
            recordL2.text = "-------";
        }

        if (PlayerPrefs.GetFloat("R3f") == 0f)
        {
            recordL3.text = "-------";
        }
    }
}