using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiespawner : MonoBehaviour
{
    public GameObject zombie;
    void Start()
    {
        StartCoroutine(StaggeredSpawn());
    }
    IEnumerator StaggeredSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            spawnObject();
        }
    }
    void spawnObject()
    {
        float randomY = Random.Range(-10f, 5f);
        Vector2 spawnPosition = new Vector2(transform.position.x, randomY);
        Instantiate(zombie, spawnPosition, Quaternion.identity);
    }
}
