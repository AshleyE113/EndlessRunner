using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This plays the BG music and pauses it once the player dies. I brushed up on audio
 with this source: https://gamedevbeginner.com/how-to-play-audio-in-unity-with-examples/
 It's a very good website which breaks down different things in Unity and builds upon
 them for more complex tasks.*/
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
