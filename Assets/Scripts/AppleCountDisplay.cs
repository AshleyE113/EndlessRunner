using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*Shows the number of Apples the Player collected*/
public class AppleCountDisplay : MonoBehaviour
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
        GetComponent<TMP_Text>().text = "Apples: " + gs.a_count.ToString();
    }
}
