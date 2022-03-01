using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Sets the left and right bounds for the player
 */
public class LevelBounds : MonoBehaviour
{

    [SerializeField] public static float leftSide = -0.51f;
    [SerializeField] public static float rightSide = 1.37f;
    public float internalLeft;
    public float internalRight;
    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
