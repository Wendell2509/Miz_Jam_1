using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;

    private void Start()
    {
    }

    private void Update()
    {
        if (player)
        {
            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        }
    }
}