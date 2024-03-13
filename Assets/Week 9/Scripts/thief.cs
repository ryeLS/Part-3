using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thief : Villager
{
    public GameObject dagger;
    public Transform spawn;
    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
    protected override void Attack()
    {
        destination = transform.position;
        base.Attack();
        Instantiate(dagger, spawn.position, spawn.rotation);
        Instantiate(dagger, spawn.position, spawn.rotation);
    }
}
