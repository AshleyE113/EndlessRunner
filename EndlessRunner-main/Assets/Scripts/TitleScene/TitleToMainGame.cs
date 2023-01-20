using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Once the button in the title scene is hit, it goes into the main game.
 */
public class TitleToMainGame : MonoBehaviour
{
    public void ButtonMoveScene()
    {
        SceneManager.LoadScene("MainGame", LoadSceneMode.Single); //Loads new scene. Single only loads the Game Scene.
    }
}
