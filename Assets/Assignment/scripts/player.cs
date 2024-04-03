using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class player : MonoBehaviour
{
    float speed = 7f;
    Rigidbody2D rb;
    Vector2 destination;
    Vector2 movement;
    public GameObject pewpew;
    public float healthbar;
    public Transform spawn;
    public float maxhealth = 5;
  
    // Start is called before the first frame update
    void Start()
    {
        healthbar = maxhealth;
        rb =GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        movement =destination - (Vector2)transform.position;
        //flips him so he doesnt look so weird-
        //I mean flips him in direction hes moving(no need for 2 walk cycles)
        if(movement.x < 0)
        {
            transform.localScale = new Vector3(-1,1,1);
        }
        if(movement.x > 0)
        {
            transform.localScale = new Vector3(1,1,1);
        }
        if(movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
        }
        if(movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
        }
        rb.MovePosition(rb.position+movement.normalized*speed *Time.deltaTime);
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //if mouse clicked then player move to clicked location
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButtonDown(1)) //if mouse clicked then player move to clicked location
        {
            Shoot();
        }
    }
    public void HitTaken(float damage)
    {
        healthbar -= damage;
        Debug.Log("yeah");
        if(healthbar <= 0)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
    public void Shoot()
    {
        destination = transform.position;
        transform.localScale = new Vector3(1, 1, 1);
        Instantiate(pewpew, spawn.position, Quaternion.identity);
    }
}
