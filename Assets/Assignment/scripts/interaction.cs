using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.x < -25)
        {
            Debug.Log("hit");
            SendMessage("HitTaken", 1, SendMessageOptions.DontRequireReceiver);
        }
    }
}
