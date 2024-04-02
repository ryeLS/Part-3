using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//References
//Mini Zombie - https://opengameart.org/content/mini-zombie
//Zombie - https://opengameart.org/content/zombie-character
//Player - https://opengameart.org/content/2d-hero-guy-character
public class zombie : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(StaggeredSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.x > Screen.height || screenPosition.x < 0)
        {
            Debug.Log("haha");
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("HitTaken", 1, SendMessageOptions.DontRequireReceiver);
    }
}
