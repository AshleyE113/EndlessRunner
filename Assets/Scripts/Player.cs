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

    // Start is called before the first frame update
    void Start()
    {
        player_rb = GetComponent<Rigidbody>();
        if (GameObject.Find("LevelManager") != null)
        {
            lvl = GameObject.Find("LevelManager").GetComponent<LevelBounds>();
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World); //Makes it move forward

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < lvl.internalRight)// for the right
            {
                //Sets the bounds for the player to move
                transform.Translate(Vector3.right * Time.deltaTime * sideSpeed);
                //Debug.Log("Right");
            }
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > lvl.internalLeft) //For the left, error?
            {
                transform.Translate(Vector3.left * Time.deltaTime * sideSpeed); //Needed so it can go to the left
                //Debug.Log("Left");
            }
        }

       if (isDead)
       {
            speed = 0; //Makes the player stop moving forward
       }
    }
    // */


    //Jump code
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            player_rb.AddForce(0, force, 0, ForceMode.Impulse);
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
