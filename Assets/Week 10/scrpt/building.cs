using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class building : MonoBehaviour
{
    float interpol;
    public SpriteRenderer table;
    public SpriteRenderer chair1;
    public SpriteRenderer chair2;
    public SpriteRenderer lamp;
    public SpriteRenderer stand;
    public SpriteRenderer vase;
    public SpriteRenderer top;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        //call coroutine heere
        StartCoroutine(Build());
    }
    IEnumerator Build()
    {
        timer += Time.deltaTime;
        if (timer < 1) {
            table.transform.localScale = Vector3.Lerp(transform.localScale, transform.localScale * 2, timer);
        }
        yield return new WaitForSeconds(2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
