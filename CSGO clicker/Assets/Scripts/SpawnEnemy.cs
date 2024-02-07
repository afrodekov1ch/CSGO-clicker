using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnPoint;

    public float startSpawnerInterval;
    private float spawnerInterval;

    public int numberOfEnemies;
    public int nowTheEnemies;

    private int randomPoint;

    private void Start()
    {
        spawnerInterval = startSpawnerInterval;
    }
    private void Update()
    {
        if(spawnerInterval <= 0 && nowTheEnemies < numberOfEnemies)
        {
            randomPoint = Random.Range(0, spawnPoint.Length);

            enemy = Instantiate(enemy, spawnPoint[randomPoint].transform);

            enemy.name = "enemy";
            spawnerInterval = startSpawnerInterval;
            nowTheEnemies++;
        }
        else
        {
            spawnerInterval -= Time.deltaTime;
        }

    }
}
