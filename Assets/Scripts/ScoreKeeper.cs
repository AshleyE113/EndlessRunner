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
    // Start is called before the first frame update
    Player player;
    [SerializeField] private int player_score = 0;
    [SerializeField] private int apple_count = 0;
    [SerializeField] private TMP_Text string_score;
    private string str_score; //testing...
    public TMP_Text score_display;
    public int scoreHolder;
    public int appleHolder;

    private void Start()
    {
        player = gameObject.AddComponent(typeof(Player)) as Player; //Adds player as a component
    }

    void Update()
    {
        try //To catch null exception error
        {
            if (!player.isHit) //if the player is dead
            {
                player_score += 1;

                if (player.hitApple) //if the player gets an apple, the score and apple count go up
                {
                    player_score += 10;
                    apple_count += 1;
                    Debug.Log("Got it!");
                }
            }
        } catch (NullReferenceException e)
        {
            Debug.Log("Caught!");
        }
       

       // string_score.SetText(player_score.ToString()); //Find a way to to store this val into a string, then use it in the Death Scene canvas
        str_score = player_score.ToString();
        string_score.text = str_score; //How to handle strings and TMP_Text? With .text
        score_display = string_score;



        scoreHolder = player_score;
        appleHolder = apple_count;
        DontDestroyOnLoad(this.gameObject);

        //What if I had this work for both?

        
        /*
         * One way...
         * 
         * Have a canvasManager obj...
         * make it public and put it in the script...
         * have it control and display both varis
         * when the scene changes, have the don't
         * destroy on load, then have the text objs
         * display the final score and apple count
         * 
         * OR
         * 
         * Have 2 canvas managers: 1 for Main, 1 for Death
         * have them share the same text objs. if the player
         * dies, make the code for that main canvas null
         */
        
        
    }
}
