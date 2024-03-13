using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class archer : Villager
{
    public GameObject arrowFAB;
    public Transform spawn;
    protected override void Attack()
    {
        destination = transform.position;
        base.Attack();
        Instantiate(arrowFAB, spawn.position, spawn.rotation);
    }
    public override ChestType CanOpen()
    {
        return ChestType.Archer;
    }
}
