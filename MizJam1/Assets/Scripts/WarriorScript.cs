using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorScript : MonoBehaviour
{
    public float speed;
    public GameObject Player;
    public Vector2 direcao;

    private void Start()
    {
        Player = GameObject.Find("Player");
    }

    private void FixedUpdate()
    {
        if (Player)
        {
            direcao = new Vector2(Player.transform.position.x - transform.position.x, Player.transform.position.y - transform.position.y);
            transform.Translate(direcao * Time.deltaTime * speed);
        }
    }

    public void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name == "Player")
        {
            c.gameObject.GetComponent<PlayerController>().Respawn();
        }
    }
}