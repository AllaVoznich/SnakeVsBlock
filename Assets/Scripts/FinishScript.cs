using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.TryGetComponent(out SnakeMovement Snake)) return;
        Snake.ReachFinish();
    }
}
