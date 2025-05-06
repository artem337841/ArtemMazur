using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animal;
    public float spawnPositionZ = 20;
    public int spawnXRange;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
 

    private void SpawnRandomAnimal()
    {
        int animalRandomIndex = Random.Range(0, animal.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnXRange,spawnXRange+1), 0, spawnPositionZ);
        Instantiate(animal[animalRandomIndex], spawnPosition, animal[animalRandomIndex].transform.rotation);

    }
 }