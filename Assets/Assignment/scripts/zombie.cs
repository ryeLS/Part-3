using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//References
//Mini Zombie - https://opengameart.org/content/mini-zombie
//Zombie - https://opengameart.org/content/zombie-character
//Player - https://opengameart.org/content/2d-hero-guy-character
public class zombie : MonoBehaviour
{
    protected float speed = 3f;
    public float chances = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    protected virtual void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.x < -25)
        {
            Debug.Log("haha");
            chances = chances - 1;
            Destroy(gameObject);
        }
        if(chances <= 0)
        {
            Debug.Log("You done.");
        }
    }
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("HitTaken", 1, SendMessageOptions.DontRequireReceiver);
    }
}
