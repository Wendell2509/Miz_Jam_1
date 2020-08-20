using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorScript : MonoBehaviour
{
    public float speed;
    public float minDistance;
    public GameObject Player;
    private Vector2 playerPos;
    public Vector2 direcao;

    private void Start()
    {
        Player = GameObject.Find("Player");
    }

    private void FixedUpdate()
    {
        if (Player)
        {
            playerPos = new Vector2(Player.transform.position.x, Player.transform.position.y);

            Vector2 myPos = new Vector2(transform.position.x, transform.position.y);

            float differenceDist = Vector2.Distance(playerPos, myPos);

            if (differenceDist < minDistance)
            {
                direcao = new Vector2(Player.transform.position.x - transform.position.x, Player.transform.position.y - transform.position.y);
                direcao.Normalize();
                transform.Translate(direcao * Time.deltaTime * speed);
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name == "Player")
        {
            c.gameObject.GetComponent<PlayerController>().Respawn();
            Destroy(gameObject);
        }
    }
}