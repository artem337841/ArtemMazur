using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float leftBound = -15f;
    private void Update()
    {
        if (transform.position.x < leftBound) 
        {
            Destroy(gameObject);
        }
    }
}
