using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float startDelay = 2;
    public float repeatRate = 2;

    private Vector3 spawnPosition = new Vector3(25, 0, 0);
    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), startDelay, repeatRate);
        playerController = FindObjectOfType<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObstacle() 
    {if (playerController.isGameOver == false)
        Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
    }
}
