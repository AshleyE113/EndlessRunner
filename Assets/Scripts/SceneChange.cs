using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* When the player dies, it will go into the death state
 */

public class SceneChange : MonoBehaviour
{
    [SerializeField] Player player;
    void Update()
    {
        if (player.isDead == true)
        {
            SceneManager.LoadScene("DeathScene", LoadSceneMode.Single); //Loads the scene on its own.
        }
    }
}
