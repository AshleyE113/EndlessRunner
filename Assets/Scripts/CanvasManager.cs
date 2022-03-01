using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Player player;
    [SerializeField] Canvas showScore;
    void Start()
    {
        showScore.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isHit)
        {
         showScore.enabled = false;
        }
    }
}
