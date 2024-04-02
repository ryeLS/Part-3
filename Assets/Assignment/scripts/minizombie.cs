using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minizombie : zombie //child class
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        speed = 6f;
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.x < -25)
        {
            Debug.Log("haha");
            other.HitTaken();
            Destroy(gameObject);
        }
    }
}
