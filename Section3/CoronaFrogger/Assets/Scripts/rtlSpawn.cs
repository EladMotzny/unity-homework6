using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rtlSpawn : MonoBehaviour
{
    [Tooltip("Delay between enemy spawn")] [SerializeField] public float spawnDelay = 0.3f;

    float nextTimeToSpawn = 0f;

    [Tooltip("The prefab to spawn")] [SerializeField] public GameObject rtl;

    public Transform[] spawnPoints;

    private void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            spawnLtr();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void spawnLtr()
    {
        int rnd = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[rnd];
        Instantiate(rtl, spawnPoint.position, spawnPoint.rotation);
    }
}
