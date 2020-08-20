using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Invoke("Disable", 5f);
    }

    private void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name == "Player")
        {
            c.gameObject.GetComponent<PlayerController>().Respawn();
            gameObject.SetActive(false);
        }

        if (c.gameObject.tag == "warrior")
        {
            Destroy(c.gameObject);
            gameObject.SetActive(false);
        }

        if (c.gameObject.name != "Cannon")
        {
            gameObject.SetActive(false);
        }
    }
}