using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/* This class displays the player score as they travel through the main scene */
public class Score : MonoBehaviour
{
    GameObject Gstatus;

    void Start()
    {
        Gstatus = GameObject.Find("GameStatus");
    }

    void Update()
    {
        if (Gstatus == null)
        {
            this.enabled = false;
            return;
        }

        //Displays Score in MainGame scene
        GameStatus gs = Gstatus.GetComponent<GameStatus>();
        GetComponent<TMP_Text>().text = "Score: " + gs.p_score.ToString();
    }
}
