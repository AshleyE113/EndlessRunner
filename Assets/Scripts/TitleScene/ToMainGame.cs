using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Once the button in the title screen is hit, it goes into the main game.
 */
public class ToMainGame : MonoBehaviour
{
    public void ButtonMoveScene()
    {
        SceneManager.LoadScene("MainGame", LoadSceneMode.Single);
    }
}
