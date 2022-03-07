using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScore : MonoBehaviour
{
    private bool triggered = false;
    private UIManager uIMan;

    private void Start()
    {
        uIMan = GameObject.FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uIMan.score++;
        }
    }
}
