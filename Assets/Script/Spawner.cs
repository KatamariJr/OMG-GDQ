using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;
    public GameObject Enemy6;
    public GameObject Enemy7;
    public int maxEnemyCount;
    public int upperBound;
    public int lowerBound;
    public float spawnDelay;
    public int xPos;

    private List<GameObject> activeEnemies;



    void Start()
    {
        InvokeRepeating("spawnEnemies", spawnDelay, spawnDelay);
        activeEnemies = new List<GameObject>();
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
        int type = Random.Range(1, 8);
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
            case 4:
                activeEnemies.Add(Instantiate(Enemy4, spawnPoint, Quaternion.identity));
                break;
            case 5:
                activeEnemies.Add(Instantiate(Enemy5, spawnPoint, Quaternion.identity));
                break;
            case 6:
                activeEnemies.Add(Instantiate(Enemy6, spawnPoint, Quaternion.identity));
                break;
            case 7:
                activeEnemies.Add(Instantiate(Enemy7, spawnPoint, Quaternion.identity));
                break;
            default:
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
