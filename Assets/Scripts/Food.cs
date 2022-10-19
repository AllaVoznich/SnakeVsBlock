using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    public Transform FoodPrefab;
    public Transform Finish;

    //private Transform RandomFood;

    public bool IsEaten;
    public int FoodValue;

    public TextMeshPro foodValue;
   



    private void Start()
    {
        FoodGeneration();
        FoodGeneration();
        FoodGeneration();
        FoodGeneration();
        FoodGeneration();
        FoodGeneration();
        FoodGeneration();
        FoodGeneration();
    }



    public void FoodGeneration()
    {
        Vector3 RandomPosition = new Vector3(Random.Range(-3.4f, 3.4f), 0.5f, Random.Range(0, Finish.transform.position.z));
        Transform RandomFood = Instantiate(FoodPrefab, RandomPosition, Quaternion.identity, transform);

    }

    private void OnEnable()
    {
       FoodValue = Random.Range(1, 10);
       foodValue.text = FoodValue.ToString();
    }



}


