using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attached to food projectile prefab

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
