using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody2D player;
    public float speed = 10;
    public LogicScript Logic;
    private bool birdIsAlive = true;


    void Update()
    {
        this.CheckBirdFall();
        this.Moverment();

    }
    private void Moverment()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            player.velocity = new Vector3(0, 2, 0) * speed;
        }
    }
    private void CheckBirdFall()
    {
        if (transform.position.y < -12f) Logic.GameOver();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.GameOver();
        birdIsAlive = false;
    }
}
