using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This plays the BG music and pauses it once the player dies*/
public class MusicPlayer : MonoBehaviour
{
    GameObject Gstatus;
    GameStatus gs;
    AudioSource gameMusic;
    void Start()
    {
        Gstatus = GameObject.Find("GameStatus");
        gs = Gstatus.GetComponent<GameStatus>();
        gameMusic = GetComponent<AudioSource>();
        gameMusic.Play();

    }

    void Update()
    {
        if (!gs.startGame) //If start game is false, it pauses the music
        {
            gameMusic.Pause();
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
