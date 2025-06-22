using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject powerupPrefab;

    private float xEnemySpawn = -10.0f;
    private float xPowerupSpawn = 1.0f;
    private float zSpawnRange = 6.0f;
    private float ySpawn = 0.3f;

    private float powerupSpawnInterval = 5.0f;
    private float enemySpawnInterval = 1.0f;
    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, enemySpawnInterval);
        InvokeRepeating("SpawnPowerup", startDelay, powerupSpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomEnemy()
    {
        float RandomZ = Random.Range(-zSpawnRange, zSpawnRange);
        int randomIndex = Random.Range(0, enemyPrefabs.Length);

        Vector3 spawnPos = new Vector3(xEnemySpawn, ySpawn, RandomZ);

        Instantiate(enemyPrefabs[randomIndex], spawnPos, enemyPrefabs[randomIndex].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
            float RandomZ = Random.Range(-zSpawnRange, zSpawnRange);
        Vector3 spawnPos = new Vector3(xPowerupSpawn, ySpawn, RandomZ);
        Instantiate(powerupPrefab, spawnPos, powerupPrefab.gameObject.transform.rotation);
    }
}
