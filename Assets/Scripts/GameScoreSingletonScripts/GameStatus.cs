using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

/* This class handdles everything that has to deal with score and apple count. This is used to keep track of the score
 * and apples collected in the main game scene and stores the data so it can be displayed once the player dies
 */
public class GameStatus : MonoBehaviour
{

    public static GameStatus instance; //Singleton declaration so that it can work in 2 scenes

    public int p_score = 0; //player score
    public int a_count = 0; //apple count
    public bool startGame = true;
    private void Awake()
    {
        if (instance == null) //Destroys multiple instances to prevent problems
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this) //To prevent duplicates!
        {
            Destroy(gameObject);
        }
    }
 
}
