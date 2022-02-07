using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // variables for Dog Cool Down
    private float dogCoolDown = 1;
    private bool isDogReady = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (isDogReady && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            StartCoroutine(DogCoolDownCoroutine());
        }
    }

    // Only allow new dog after 1 second
    IEnumerator DogCoolDownCoroutine()
    {
        isDogReady = false;

        // wait one second for dog to be ready to go
        yield return new WaitForSeconds(dogCoolDown);

        isDogReady = true;
    }
}
