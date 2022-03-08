using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This class sets the left and right bounds for the player
 */
public class LevelBounds : MonoBehaviour
{
    
    public static float leftSide = -0.51f;
    public static float rightSide = 1.37f;
    public float internalLeft;
    public float internalRight;

    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
