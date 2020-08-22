using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class timerRecordManager : MonoBehaviour
{
    public Text recordL1, recordL2, recordL3;
    public static string record1, record2, record3;

    private void Start()
    {
    }

    private void Update()
    {
        recordL1.text = "" + record1;
        recordL2.text = "" + record2;
        recordL3.text = "" + record3;
    }
}