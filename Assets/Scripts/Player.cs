using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This class handles all of the player's movement controls, collision, and determines if the player is
 * dead or not. It has two Update functions (the usual and Fixed) due to the physics needed to make the
 * player jump. The bools are public so other classes can access them.
 */
public class Player : MonoBehaviour
{
    ///*
    [SerializeField] private float speed = 4; //Forward speed
    [SerializeField] private float sideSpeed = 3; //Left and right movement speed
    [SerializeField] LevelBounds lvl;
    [SerializeField] private float force;
    [SerializeField] private bool isGrounded = true;
    [SerializeField] private Rigidbody player_rb;
    public bool isHit = false;
    public bool isDead = false;
    public bool hitApple = false;

    //For Audio
    AudioSource jumpSFX;
    AudioSource collectSFX;
    [SerializeField] private AudioClip j_sfx;
    [SerializeField] private AudioClip collect_sfx;
    [SerializeField] private float sfx_vol = 0.5f;


    void Start()
    {
        player_rb = GetComponent<Rigidbody>();
        jumpSFX = GetComponent<AudioSource>();
        collectSFX = GetComponent<AudioSource>();
        if (GameObject.Find("LevelManager") != null)
        {
            lvl = GameObject.Find("LevelManager").GetComponent<LevelBounds>();
        }
        
    }

    void Update()
    {
        //Movement Code
        if (isDead == false && GameStatus.instance.startGame)
        {
            GameStatus.instance.p_score++;
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World); //Makes it move forward 

            if (Input.GetKey(KeyCode.RightArrow))
            {
                //Sets the bounds for the player to move
                if (this.gameObject.transform.position.x < lvl.internalRight)// for the right
                {
                    
                    transform.Translate(Vector3.right * Time.deltaTime * sideSpeed);
                }
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > lvl.internalLeft)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * sideSpeed);
   
                }
            }
        }

       if (isDead == true)
       {
            speed = 0; //Makes the player stop moving forward
            sideSpeed = 0; 
            GameStatus.instance.startGame = false;
       }
    }

    //Jump code
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            player_rb.AddForce(0, force, 0, ForceMode.Impulse);
            jumpSFX.PlayOneShot(j_sfx, sfx_vol);
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        isGrounded = true;

        if (col.gameObject.tag == "Obstacle")
        {
            isHit = true;
            isDead = true;
        }

        if (col.gameObject.tag == "Apple")
        {
            hitApple = true;
            collectSFX.PlayOneShot(collect_sfx, sfx_vol);
            GameStatus.instance.a_count++;

            Destroy(col.gameObject); //Destroys apple after collision
        }
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Apple")
        {
            hitApple = false;
        }
    }



}
