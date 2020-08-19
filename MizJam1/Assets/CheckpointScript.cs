using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    private void Start()
    {
    }

    private void Update()
    {
    }

    public void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.name == "Player")
        {
            print("New Checkpoint: " + transform.position);
            PlayerController.Checkpoint = transform.position;
        }
    }
}