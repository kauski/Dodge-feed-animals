using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class SpwnAggressive : MonoBehaviour
{
    public GameObject agroDog;
    public float spawnPosMin;
    public float spawnPosMax;
    public float spawnDistance;
    public float spawnTimer = 2.0f;
    public float startTimer = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAgro", startTimer, spawnTimer);   
    }

    // Update is called once per frame
    

    void SpawnAgro()
    {
        //spawns agressive
        Vector3 spawnPos = new Vector3(spawnDistance, 0, RandomNumber(spawnPosMin, spawnPosMax));

        Instantiate(agroDog, spawnPos, agroDog.transform.rotation);
    }

    T RandomNumber<T>(T minX, T maxX)
    {
        int seed = DateTime.Now.GetHashCode();
        System.Random random = new System.Random(seed);

        double minDouble = Convert.ToDouble(minX);
        double maxDouble = Convert.ToDouble(maxX);

        double randomDouble = random.NextDouble() * (maxDouble - minDouble) + minDouble;

        return (T)Convert.ChangeType(randomDouble, typeof(T));
    }
}
