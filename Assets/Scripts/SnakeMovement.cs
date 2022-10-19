using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public float Speed;
    public float XSpeed;
    public float Sensetivity;

    public Game Game;

    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);


        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * XSpeed * Time.deltaTime * Sensetivity);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * XSpeed * Time.deltaTime * Sensetivity);
        }
    }

    public void Die()
    {
        Game.OnPlayerDied();
    }
       
    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
    }
 }

   




