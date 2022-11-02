using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPS : MonoBehaviour
{

    public ParticleSystem particleSystem;

    public void DestroyEffect()
    {
        particleSystem.Play();
    }
}  
