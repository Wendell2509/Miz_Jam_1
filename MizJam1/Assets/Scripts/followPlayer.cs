using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;
    private bool followPlayerActive;

    private void Start()
    {
        followPlayerActive = false;
        Invoke("followPlayerAt", 2f);
    }

    private void FixedUpdate()
    {
        if (player && followPlayerActive)
        {
            Vector3 desiredPosition = player.transform.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;

            //transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        }
    }

    private void followPlayerAt()
    {
        followPlayerActive = true;
    }
}