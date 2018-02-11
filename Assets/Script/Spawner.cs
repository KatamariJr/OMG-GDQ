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

    private List<GameObject> activeEnemies;



    void Start()
    {
        InvokeRepeating("spawnEnemies", spawnDelay, spawnDelay);
    }

    void Update()
    {
        foreach (GameObject e in activeEnemies)
        {
            if ((e.transform.position.x <= -10) || (e.transform.position.y <= -10) || (e.transform.position.y >= 10))
            {
                activeEnemies.Remove(e);
                Destroy(e);
                
            }
        }
    }

    void spawnEnemies()
    {
        int type = Random.Range(1, 4);
        int yPos = Random.Range(lowerBound, upperBound);
        Vector2 spawnPoint = new Vector2(xPos, yPos);

        switch (type)
        {


            case 1:
                activeEnemies.Add(Instantiate(Enemy1, spawnPoint, Quaternion.identity));
                break;

            case 2:
                activeEnemies.Add(Instantiate(Enemy2, spawnPoint, Quaternion.identity));
                break;

            case 3:
                activeEnemies.Add(Instantiate(Enemy3, spawnPoint, Quaternion.identity));
                break;
        }
    }

    public void clearEnemies()
    {
        foreach (GameObject e in activeEnemies)
        {
                Destroy(e);
        }
        activeEnemies.Clear();
    }
}
