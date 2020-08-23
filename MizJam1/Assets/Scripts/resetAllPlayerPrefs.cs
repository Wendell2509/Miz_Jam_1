using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetAllPlayerPrefs : MonoBehaviour
{
    public void _DeleteAllKeys()
    {
        PlayerPrefs.DeleteAll();
        print("All saves reseted");
    }
}