using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScore : MonoBehaviour
{

    private UIManager uIMan;

    private bool triggered = false;

    // Start is called before the first frame update
    void Start()
    {
        uIMan = GameObject.FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uIMan.score++;
        }
    }
}
