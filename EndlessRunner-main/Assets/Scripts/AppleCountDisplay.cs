using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*This class shows the number of Apples the Player collected*/
public class AppleCountDisplay : MonoBehaviour
{
    GameObject Gstatus;
    void Start()
    {
        Gstatus = GameObject.Find("GameStatus"); //Looks for the GameStatusobj
    }
    void Update()
    {
        if (Gstatus == null) //If it's not there, don't execute the code outside of the if.
        {
            this.enabled = false;
            return;
        }
        //For showing the amount of apples the player collected
        GameStatus gs = Gstatus.GetComponent<GameStatus>();
        GetComponent<TMP_Text>().text = "Apples: " + gs.a_count.ToString();
    }
}
