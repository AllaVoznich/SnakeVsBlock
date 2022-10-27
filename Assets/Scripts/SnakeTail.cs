using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static Game;

public class SnakeTail : MonoBehaviour
{
    private List<Transform> Circles = new List<Transform>();
    public Transform SnakeHead;

    public SnakeMovement Snake;

    public Dissolve Dissolve;

    private void Start()
    {
        Circles.Add(SnakeHead);
    }

       private void FixedUpdate()
    {
        if (Circles.Count>0)
        {
            Circles[0].transform.position = transform.position;

            for (int j = Circles.Count - 1; j > 0; j--)
            {
                Circles[j].transform.position = Circles[j - 1].transform.position - Vector3.forward;
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            Destroy(other.gameObject);


            if (other.gameObject.TryGetComponent<Food>(out Food food))
            {

                if (!food.IsEaten)
                {
                    food.IsEaten = true;
                    var FoodValue = food.FoodValue;
                    for (int i = 0; i < FoodValue; i++)
                    {
                        AddCircle();
                    }
                }
            }
        }

        if (other.gameObject.CompareTag("Block"))
        {
            Destroy(other.gameObject);
            Dissolve.Gone();
            
            if (other.gameObject.TryGetComponent<Block>(out Block block))
            {   
                var BlockValue = block.BlockValue;
                
                if (!block.IsFaced)
                {

                    if (Circles.Count - BlockValue > 0)                                                 
                    {
                        block.IsFaced = true;
                        
                        for (int i = 0; i < BlockValue; i++)
                        {
                            RemoveCircle(i);
                        }
                    }

                    else 
                    {
                        Snake.Die();
                    }

                }
            }
        }
    }


    public void AddCircle()
    {
        Vector3 Position = transform.position;
        if (Circles.Count > 0) { Position = Circles[Circles.Count - 1].transform.position; }
        Transform circle = Instantiate(SnakeHead, Position, Quaternion.identity, transform);
        Circles.Add(circle);
       
    }

    public void RemoveCircle(int value)
    {

        int index = Circles.Count - value - 1;                                                                  
        if (index > 0)
        {
            Destroy(Circles[index].gameObject);
            Circles.Remove(Circles[index]);
        }
        else
            return;
    }


   
}



