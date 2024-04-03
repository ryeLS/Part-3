using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigzombie : zombie
{
    public GameObject normalzombie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        speed = 1f;
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.x < -25)
        {
            Debug.Log("haha");
            other.HitTaken(2);
            spawnSmaller();
            Destroy(gameObject);
        }
    }
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("HitTaken", 2, SendMessageOptions.DontRequireReceiver);
    }
    protected void spawnSmaller()
    {
        Instantiate(normalzombie, transform.position, Quaternion.identity);
    }
}
