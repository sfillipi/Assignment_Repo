using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    public float jumpForce;
    public ForceMode forceMode;
    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;

    public Animator playerAnimator;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;

    private AudioSource playerAudio;



    // Start is called before the first frame update
    void Start()
    {
        //set a reference to the rigidbody component
        rb = GetComponent<Rigidbody>();

        //set a reference to ani component
        playerAnimator = GetComponent<Animator>();

        //set reference to audio source
        playerAudio = GetComponent<AudioSource>();

        //start running animation on start
        playerAnimator.SetFloat("Speed_f", 1.0f);

        forceMode = ForceMode.Impulse;

        //modify gravity
        if (Physics.gravity.y > -10)
        {
            Physics.gravity *= gravityModifier;
        }


    }

    // Update is called once per frame
    void Update()
    {
        // jump when space is pressed
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, forceMode);
            isOnGround = false;

            //set the trigger for jump ani
            playerAnimator.SetTrigger("Jump_trig");

            //stop playing dirt particle on jump
            dirtParticle.Stop();

            //play jump sfx
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;

            //play dirt ani when player is on ground
            dirtParticle.Play();
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
            gameOver = true;

            //play death ani
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);

            //stop dirt
            dirtParticle.Stop();

            //play explosion
            explosionParticle.Play();

            //play crash sfx
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
