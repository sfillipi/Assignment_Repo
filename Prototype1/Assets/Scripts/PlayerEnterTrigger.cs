﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Attach this to player
public class PlayerEnterTrigger : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
}
