using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    private Renderer Material;
    float Float;


    public void Start()
    {
        Material = gameObject.GetComponent<Renderer>();
    }
    public IEnumerator DissolvePlayer()
    {
        for (float Float = -0.2f; Float <= 1; Float += 0.05f)
        {
            Material.material.SetFloat("_Float", Float);
            yield return null;
        }


    }
    public void Gone()
    {
        StartCoroutine(DissolvePlayer());
    }


}
