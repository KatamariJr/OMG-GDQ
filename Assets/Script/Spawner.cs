using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public int maxEnemyCount;
    public int upperBound;
    public int lowerBound;
    public float spawnDelay;
    public int xPos;

    void Start()
    {
        InvokeRepeating("spawnEnemies", spawnDelay, spawnDelay);
    }

    void spawnEnemies()
    {
        int type = Random.Range(1, 4);
        int yPos = Random.Range(lowerBound, upperBound);
        Vector2 spawnPoint = new Vector2(xPos, yPos);

        if (type == 1)
        {
            Instantiate(Enemy1, spawnPoint, Quaternion.identity);
        }
        else if (type == 2)
        {
            Instantiate(Enemy2, spawnPoint, Quaternion.identity);
        }
        else if (type == 3)
        {
            Instantiate(Enemy3, spawnPoint, Quaternion.identity);
        }
    }
}
