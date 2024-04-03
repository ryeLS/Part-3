using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiespawner : MonoBehaviour
{
    public GameObject minizombie;
    public GameObject zombie;
    public GameObject bigzombie;
    static bool gameRunning = true;//static variable
    void Start()
    {
        StartCoroutine(StaggeredSpawn());//coroutine
    }
    IEnumerator StaggeredSpawn()//coroutine
    {
        while (gameRunning)
        {
            yield return new WaitForSeconds(3f);
            spawnObject();
        }
    }

    void spawnObject()
    {
        float randomY = Random.Range(-10f, 10f);
        Vector2 spawnPosition = new Vector2(transform.position.x, randomY);
        //Instantiate(zombie, spawnPosition, Quaternion.identity);
        int randomZombie = Random.Range(0, 3);
        switch (randomZombie)
        {
            case 0:
                Instantiate(zombie, spawnPosition, Quaternion.identity);
                
                break;
            case 1:
                Instantiate(minizombie, spawnPosition, Quaternion.identity);
                
                break;
            case 2:
                Instantiate(bigzombie, spawnPosition, Quaternion.identity);
                break;
        }

    }
}
