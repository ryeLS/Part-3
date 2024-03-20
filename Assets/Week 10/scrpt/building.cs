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
    float timer=0;
    

    // Start is called before the first frame update
    void Start()
    {
        //call coroutine heere
        StartCoroutine(Build());
    }
    IEnumerator Build()
    {
        table.transform.localScale = Vector3.zero;
        chair1.transform.localScale = Vector3.zero;
        chair2.transform.localScale = Vector3.zero;
        lamp.transform.localScale = Vector3.zero;
        stand.transform.localScale = Vector3.zero;
        vase.transform.localScale = Vector3.zero;
        top.transform.localScale = Vector3.zero;

        while ( table.transform.localScale.z < 1) {
            timer += Time.deltaTime;
            table.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, timer);
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);
        timer = 0;
        while (chair1.transform.localScale.z < 1)
        {
            timer += Time.deltaTime;
            chair1.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, timer);
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);
        timer = 0;
        while (chair2.transform.localScale.z < 1)
        {
            timer += Time.deltaTime;
            chair2.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, timer);
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);
        timer = 0;
        while (lamp.transform.localScale.z < 1)
        {
            timer += Time.deltaTime;
            lamp.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, timer);
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);
        timer = 0;
        while (vase.transform.localScale.z < 1)
        {
            timer += Time.deltaTime;
            vase.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, timer);
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);
        timer = 0;
        while (stand.transform.localScale.z < 1)
        {
            timer += Time.deltaTime;
            stand.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, timer);
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);
        timer = 0;
        while (top.transform.localScale.z < 2)
        {
            timer += Time.deltaTime;
            top.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, timer);
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);
        timer = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
