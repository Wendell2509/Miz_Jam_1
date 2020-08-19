using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikesScript : MonoBehaviour
{
    private void Start()
    {
    }

    private void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name == "Player")
        {
            c.gameObject.GetComponent<PlayerController>().Respawn();
        }
    }
}