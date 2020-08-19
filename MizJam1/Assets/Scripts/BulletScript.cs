using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 5);
    }

    private void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name == "Player")
        {
            c.gameObject.GetComponent<PlayerController>().Respawn();
        }

        if (c.gameObject.name != "Cannon")
        {
            Destroy(gameObject);
        }
    }
}