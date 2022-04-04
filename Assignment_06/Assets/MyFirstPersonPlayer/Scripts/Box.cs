using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : Target
{
    protected override void Awake()
    {
        base.Awake();
        boxHealth = 50;
    }
}
