using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{
    public Transform BlockPrefab;
    public Transform Finish;

    public bool IsFaced;
    public int BlockValue;

   // private Transform RandomBlock;


    public TextMeshPro blockValue;


    public Gradient Gradient;
   

    public int MaxBlockValue = 10;


    private void Start()
    {  
        BlockGeneration();
        BlockGeneration();
        BlockGeneration();
        BlockGeneration();
        BlockGeneration();
        BlockGeneration();
        BlockGeneration();
        BlockGeneration();
       

    }

    private void Update()
    {
        if (transform.gameObject.TryGetComponent<Block>(out Block value)) 
        {
          
            var BlockValue = value.BlockValue;
            SetColor(BlockValue);
        }
    }


    public void BlockGeneration()
    {
        Vector3 RandomPosition = new Vector3(Random.Range(-3.4f, 3.4f), 0.5f, Random.Range(0, Finish.transform.position.z));
        Transform RandomBlock = Instantiate(BlockPrefab, RandomPosition, Quaternion.identity, transform);

    }

    private void OnEnable()
    {
        BlockValue = Random.Range(1, 10);
        blockValue.text = BlockValue.ToString();

        
    }

    public void SetColor(int value)
    { 
        transform.gameObject.GetComponent<Renderer>().material.color = Gradient.Evaluate(value / (float) MaxBlockValue);
       // Debug.Log(Gradient.Evaluate(value / (float)MaxBlockValue));
    }

}