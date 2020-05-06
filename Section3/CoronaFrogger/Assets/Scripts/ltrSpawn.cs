using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ltrSpawn : MonoBehaviour
{
    [Tooltip("Delay between enemy spawn")] [SerializeField] public float spawnDelay = 0.3f;

    float nextTimeToSpawn = 0f;

    [Tooltip("The prefab to spawn")] [SerializeField] public GameObject ltr;

    public Transform[] spawnPoints;


    private void Update()
    {
        if(nextTimeToSpawn <= Time.time)
        {
            spawnLtr();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void spawnLtr()
    {
        int rnd = Random.Range(0,spawnPoints.Length);
        Transform spawnPoint = spawnPoints[rnd];
        Instantiate(ltr, spawnPoint.position, spawnPoint.rotation);
    }
}
