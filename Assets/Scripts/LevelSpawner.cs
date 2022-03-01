using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This class spawns the segements of the level, allowing it to be an infinite runner.
 */
public class LevelSpawner : MonoBehaviour
{
    public GameObject[] lvlpiece; //An array to store the segments in
    public float zPos = 9.99f;
    public int yRot = 90;
    public bool createPiece = false;
    public int pieceNum;

    void Update()
    {
        if (createPiece == false)
        {
            createPiece = true;
            StartCoroutine(SpawnPiece());
        }
    }

    IEnumerator SpawnPiece() //Soawns a random piece over 2 seconds.
    {
        pieceNum = Random.Range(0, lvlpiece.Length - 1);
        Instantiate(lvlpiece[pieceNum], new Vector3(0, 0, zPos), Quaternion.Euler(0, yRot, 0));
        zPos += 10;
        yield return new WaitForSeconds(2);
        createPiece = false;
    }
}
