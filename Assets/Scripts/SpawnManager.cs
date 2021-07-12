using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject missile;
    private float xRange = 50;
    private float zRange = 50;
    private float spawnDist = 70;

    private float startDelay = 2.0f;
    private float spawnInterval = 3.0f;
    private float intervalDecrease = 0.99f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMissile", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnMissile()
    {
        float xCor = Random.Range(-xRange, xRange);
        float zCor = Random.Range(-zRange, zRange);
        while (xCor * xCor + zCor * zCor < spawnDist * spawnDist)
        {
            xCor *= 2;
            zCor *= 2;
        }
        Instantiate(missile, new Vector3(xCor, 0, zCor), missile.transform.rotation);
        spawnInterval *= intervalDecrease;
    }
}
