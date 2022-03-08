using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This class handdles everything that has to deal with score and apple count. This is used to keep track of the score
 * and apples collected in the main game scene and stores the data so it can be displayed once the player dies
 */
public class GameStatus : MonoBehaviour
{
    public static GameStatus instance; //Singleton declaration so that it can work in 2 scenes

    public int p_score = 0;
    public int highScore;
    public int a_count = 0; //apple count
    public bool startGame = true;
    private void Awake()
    {
        instance = this;   
    }
    void Start()
    {
       // p_score = PlayerPrefs.GetInt("p_score", 0);
        //highScore = PlayerPrefs.GetInt("highScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void OnDestroy()
    {
       // PlayerPrefs.SetInt("p_score", p_score);
        //PlayerPrefs.SetInt("highScore", highScore);
    }

    public void UpdateScore() //Updates Score
    {
        p_score++;
        //UpdateHighScore();
    }

    public void UpdateAppleCount() //Updates Apple Count
    {
        a_count++;
    }

    /*
    public void UpdateHighScore() //Updates the HS
    {
        if (p_score > highScore)
        {
            highScore = p_score;
        }
    }*/

    public void ResetScore()
    {
        p_score = 0;
        a_count = 0;
    }

}
