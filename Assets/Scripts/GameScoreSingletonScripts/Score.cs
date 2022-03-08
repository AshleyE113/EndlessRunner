using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/* This class displays the player score as they travel through the main scene */
public class Score : MonoBehaviour
{
    GameObject Gstatus;
    // Start is called before the first frame update
    void Start()
    {
        Gstatus = GameObject.Find("GameStatus");
    }

    // Update is called once per frame
    void Update()
    {
        if (Gstatus == null)
        {
            this.enabled = false;
            return;
        }

        GameStatus gs = Gstatus.GetComponent<GameStatus>();
        GetComponent<TMP_Text>().text = "Score: " + gs.p_score.ToString();
        Debug.Log("Score track in main scene");
        //DontDestroyOnLoad(this.gameObject);
    }
}
