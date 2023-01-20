using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Once the button in the death scene is hit, it goes into the main game and sets the score back to 0.
 */
public class ToMainGame : MonoBehaviour
{
    GameObject Gstatus;
    GameStatus gs;
    void Start()
    {
        Gstatus = GameObject.Find("GameStatus");
        if (Gstatus == null)
        {
            this.enabled = false;
            return;
        }

        gs = Gstatus.GetComponent<GameStatus>();
    }

    public void ButtonMoveScene()
    {
        SceneManager.LoadScene("MainGame", LoadSceneMode.Single); //Loads new scene. Single only loads the Game Scene.

       //Resets these values
        gs.p_score = 0;
        gs.a_count = 0;
        gs.startGame = true;

    }
}
