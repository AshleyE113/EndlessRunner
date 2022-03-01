using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Allows the apples to rotate on the Y axis.
 */
public class RotateObject : MonoBehaviour
{
    
    [SerializeField] private float rotSpeed = 1.5f;
    void Update()
    {
        transform.Rotate(0, rotSpeed, 0, Space.World);
    }
}
