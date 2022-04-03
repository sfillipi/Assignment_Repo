/*
 * (Sydney Fillipi)
 * (Assignment 5B)
 * (Trigger win when player enters trigger zone)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWin : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("EndZone"))
        {
            gameOver = true;
            gameOverText.SetActive(true);
        }
    }
}
