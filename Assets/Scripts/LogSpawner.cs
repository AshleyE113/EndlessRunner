using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private float spawnPerSecond = 1.0f;
    [SerializeField] private float spawnTimer;

    void Update()
    {
        spawnTimer -= Time.deltaTime;

        while (spawnTimer < 0.0f)
        {
            spawnTimer += spawnPerSecond;

            Instantiate(prefab, transform.position, Quaternion.Euler(0, 0, 90));
        }

    }
}
