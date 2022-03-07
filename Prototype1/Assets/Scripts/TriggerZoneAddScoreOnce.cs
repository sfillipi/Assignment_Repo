/*
* (Sydney Fillipi)
* (Assignment 02)
* (Adds to the score when each trigger is entered.)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attach this to a trigger zone
public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
