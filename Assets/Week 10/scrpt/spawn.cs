using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject buildPrefab;
    public Transform spawnTransform;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(buildPrefab,spawnTransform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
