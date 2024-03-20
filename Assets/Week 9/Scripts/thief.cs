using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class thief : Villager
{
    public GameObject dagger;
    public Transform spawn;
    //public float timer;
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
        speed = 7;
        while (speed>3 )
        {
            yield return null;
        }

        base.Attack();
        yield return new WaitForSeconds(0.1f);
            Instantiate(dagger, spawn.position, spawn.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(dagger, spawn.position, spawn.rotation);
            

    }

    public override string ToString()
    {
        return "yo mama";
    }
}
