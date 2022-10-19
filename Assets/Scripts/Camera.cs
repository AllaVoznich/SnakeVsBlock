using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Camera : MonoBehaviour
{
    public Transform Target;

    void Update()
    {
        Vector3 Position = transform.position;
        Position.z = Target.position.z;
        transform.position = Position;
    }
}
