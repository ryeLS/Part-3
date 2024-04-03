using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 5f;
    public GameObject bulletSpawn;
    public player spawner;

    private void Start()
    {

    }
    private void Awake()
    {
        bulletSpawn = GameObject.Find("Player");
        spawner = bulletSpawn.GetComponent<player>();
    }
    void Update()
    {
        transform.Translate(transform.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("defeated",SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject);
    }
}
