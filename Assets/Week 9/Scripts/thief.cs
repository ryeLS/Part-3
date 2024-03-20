using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class thief : Villager
{
    public GameObject dagger;
    public Transform spawn;
    public float Tspeed = 7;
    //public float timer;
    //public float dashtime = 1;
    //bool isDash;
    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
    protected override void Attack()
    {
        StartCoroutine(dash());

    }
    IEnumerator dash()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Tspeed = 7;
        while (Tspeed>3 )
        {
            yield return null;
        }
        //timer -= Time.deltaTime;
        //if(timer < 0)
        //{
        //    isDash = false;
        base.Attack();
        yield return new WaitForSeconds(0.1f);
            Instantiate(dagger, spawn.position, spawn.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(dagger, spawn.position, spawn.rotation);
            
        //}
    }
    //protected override void Update()
    //{
    //    base.Update();
    //    if (isDash)
    //    {
    //        dash();
    //    }
    //}
    public override string ToString()
    {
        return "yo mama";
    }
}
