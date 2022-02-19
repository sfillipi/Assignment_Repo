/*
 * (Sydney Fillipi)
 * (Challenge_03)
 * (Script to control player, define collisions with bomb and money)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerX : MonoBehaviour
{
    public bool gameOver;

    public float floatForce;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;

    Vector3 upBound = new Vector3(-3, 15, 0);
    Vector3 downBound = new Vector3(-3, 1.2f, 0);

    public UIManager uIMan;

    // Start is called before the first frame update
    void Start()
    {

        //set reference to the rigidbody
        playerRb = GetComponent<Rigidbody>();

        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

        uIMan = GameObject.FindObjectOfType<UIManager>();

    }

    // Update is called once per frame
    void Update()
    {

        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !gameOver)
        {
            playerRb.AddForce(Vector3.up * floatForce);

        }

        BoundLimit();

    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        }

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);
            uIMan.score++;

        }

    }

    void BoundLimit()
    {

        if (transform.position.y > 15)
        {
            transform.position = upBound;
        }
        else if (transform.position.y < 1.2)
        {
            transform.position = downBound;
        }

    }

}
