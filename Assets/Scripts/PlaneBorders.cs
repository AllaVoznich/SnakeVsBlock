using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneBorders : MonoBehaviour
{

    public float xRange;
    void Update()
    {

        if (transform.position.x > xRange )
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }
        else if (transform.position.x < -xRange)
       {
         transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
       }
    }

}
