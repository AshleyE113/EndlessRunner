using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using UnityEngine.S

/* This class keeps track of the player's score and how many apples they caught. It uses a variable
 * named string_score and ToString() so it can display the score with the TextMeshPro Gameobject
 * The Holder variables are for the death scene so it can display the players score and count once they die.
 */
public class ScoreKeeper : MonoBehaviour
{
    /*
    //public static ScoreKeeper instance; 
    // Start is called before the first frame update
    Player player;
    private int player_score = 0;
    private int apple_count = 0;
    [SerializeField] private TMP_Text string_score; 
    public Canvas displayCanvas; //Puts a canvas in here, will use this for both scenes.
    private string str_score; //testing...
    //TMP_Text score_display;
    public int scoreHolder;
    public int appleHolder;

   /* private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        displayCanvas.enabled = false;
        //player = GetComponentInParent<Player>(); //Adds player as a component
       //player = GetComponent<>
    }

    void Update()
    {
        if (player.isDead == false) //if the player is not dead
        {
            displayCanvas.enabled = true;
            player_score += 1;

           if (player.hitApple) //if the player gets an apple, the score and apple count go up
           {
                player_score += 10;
                apple_count += 1;
                Debug.Log("Got it!");
           }

            str_score = player_score.ToString();
            string_score.text = str_score;

            scoreHolder = player_score;
            appleHolder = apple_count;

        }
       

       // string_score.SetText(player_score.ToString()); //Find a way to to store this val into a string, then use it in the Death Scene canvas
         //How to handle strings and TMP_Text? With .text
        //score_display = string_score;



        
        DontDestroyOnLoad(this.gameObject);
       

        //What if I had this work for both?

        
        /*
         * One way...
         * 
         * Have a canvasManager obj...
         * make it public and put it in the script...
         * have it control and display both varis
         * when the scene changes, have the canvas don't
         * destroy on load, then have the text objs
         * display the final score and apple count
         * 
         * OR
         * 
         * Have 2 canvas managers: 1 for Main, 1 for Death
         * have them share the same text objs. if the player
         * dies, make the code for that main canvas null
         
        
        
    } */
}
