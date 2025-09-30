using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10;
    public float gravityMod;
    public bool isOnGround = true;
    public bool isGameOver;

    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;

    private Rigidbody playerRigidbody;
    private Animator playerAnimator;
    private AudioSource playerAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = gameObject.GetComponent<Animator>();
        playerAudioSource = GetComponent<AudioSource>();
        Physics.gravity = Physics.gravity * gravityMod;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true && isGameOver == false) 
        {
            isOnGround = false;
            playerRigidbody.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
            playerAnimator.SetTrigger("Jump_trig");
            playerAudioSource.PlayOneShot(jumpSound);
            dirtParticle.Stop();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.TryGetComponent(out Obstacle obstcale) && isGameOver == false)
        {
            isOnGround = true;
            dirtParticle.Play();
        }
        else
        {
            isGameOver = true;
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            playerAudioSource.PlayOneShot(crashSound);
            dirtParticle.Stop();
        }

        
    }
}

