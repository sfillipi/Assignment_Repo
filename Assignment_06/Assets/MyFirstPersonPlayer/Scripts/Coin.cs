using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Target
{
    protected override void Awake()
    {
        base.Awake();
        coinHealth = 70;
    }
}
