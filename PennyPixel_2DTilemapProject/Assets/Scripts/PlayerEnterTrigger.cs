using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEnterTrigger : MonoBehaviour
{
    public bool gameOver = false;
    public GameObject gameOverText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Finish"))
        {
            gameOver = true;

            gameOverText.SetActive(true);

        }
    }
}
