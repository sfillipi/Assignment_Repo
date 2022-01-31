/*
* (Sydney Fillipi)
* (Challenge 1)
* (If the player falls off, the player loses.)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Attached to player
public class LoseOutofBounds : MonoBehaviour
{
    public GameObject player;
    public Text textbox;

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y > 80 || player.transform.position.y < -51)
        {
            ScoreManager.gameOver = true;
        }
    }
}