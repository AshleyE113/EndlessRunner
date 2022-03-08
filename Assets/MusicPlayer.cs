using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
        if (!gs.startGame)
        {
            gameMusic.Pause();
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
