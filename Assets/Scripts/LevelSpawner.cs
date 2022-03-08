using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This class spawns the segements of the level, allowing it to be an infinite runner.
 */
public class LevelSpawner : MonoBehaviour
{
    public GameObject[] lvlpiece; //An array to store the segments in
    public float zPos = 9.99f;
    public int yRot = 90; //Makes them spawn at the right angle
    public bool createPiece = false;
    public int pieceNum;
    private const float WFSTIME = 2f;

    void Update()
    {
        //Runs the spawner
        if (createPiece == false)
        {
            createPiece = true;
            StartCoroutine(SpawnPiece());
        }
    }

    IEnumerator SpawnPiece() //Spawns a random piece over 2 seconds.
    {
        pieceNum = Random.Range(0, lvlpiece.Length - 1); //Generates a random segment number
        Instantiate(lvlpiece[pieceNum], new Vector3(0, 0, zPos), Quaternion.Euler(0, yRot, 0)); //Spawns it with the Quaternion ruler to rotate it.
        zPos += 10; //Spawns each platform at this distance so they don't overlap
        yield return new WaitForSeconds(WFSTIME);
        createPiece = false;
    }
}
