using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thief : Villager
{
    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
}
