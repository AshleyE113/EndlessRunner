using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/* Possible thanks to this video: https://www.youtube.com/watch?v=c4862qdU5Uw&ab_channel=CodeLearner*/
public class HighScore : MonoBehaviour
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
        GetComponent<TMP_Text>().text = "Score: " + gs.highScore;
    }
}
