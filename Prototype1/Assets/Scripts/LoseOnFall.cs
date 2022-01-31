/*
* (Sydney Fillipi)
* (Assignment 02)
* (If the player falls off, the player loses.)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attached to player
public class LoseOnFall : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
