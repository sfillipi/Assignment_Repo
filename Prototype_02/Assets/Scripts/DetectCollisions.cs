/*
* (Sydney Fillipi)
* (Assignment 03 - Protoype)
* (Allow player to destroy animals with food, adding to the score.)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attached to food projectile prefab

public class DetectCollisions : MonoBehaviour
{

    private DisplayScore displayScoreScript;

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
