using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        InvokeRepeating("SpawnRandomCar", startDelay, spawnInterval/ MainManager.Instance.difficulty);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomCar()
    {
        if (!gameManager.isGameOver) { 
        int carIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, transform.position.z);
        Instantiate(animalPrefabs[carIndex], spawnPos, animalPrefabs[carIndex].transform.rotation);
        }
    }
}
