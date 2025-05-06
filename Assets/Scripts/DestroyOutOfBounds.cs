using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topbound = 30;
    private float lowbound = -10;
    private void Update()
    {
        if (transform.position.z >= topbound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z <= lowbound)
        {
            Destroy(gameObject);
        }
    }
}
