using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float h, v;
    public float speed = 4;
    public float runMultiplier;
    public KeyCode runKey;
    public static Vector2 Checkpoint;

    private void Start()
    {
        Checkpoint = new Vector2(0, 0);// in the start the begging is the checkpoint
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Update()
    {
    }

    private void Movement()
    {
        h = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        v = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        if (Input.GetKey(runKey))//RUN CODE MULTIPLIER
        {
            runMultiplier = 1.5f;
        } else
        {
            runMultiplier = 1f;
        }

        transform.Translate(h * runMultiplier, v * runMultiplier, 0);
    }

    public void Respawn()
    {
        transform.position = Checkpoint;
    }
}