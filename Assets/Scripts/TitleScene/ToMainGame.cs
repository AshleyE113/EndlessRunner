using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Once the button in the title screen or death scene is hit, it goes into the main game and sets the score back to 0.
 */
public class ToMainGame : MonoBehaviour
{
    Scene scene;
    GameObject Gstatus;
    GameStatus gs;
    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
      //  scene = SceneManager.GetActiveScene();

        
       
        
    }

    public void ButtonMoveScene()
    {
        SceneManager.LoadScene("MainGame", LoadSceneMode.Single);

        gs.ResetScore();
        gs.p_score = 0;
       // gs.startGame = true; //Once it

    }
}
