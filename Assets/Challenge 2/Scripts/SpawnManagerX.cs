using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnIntervalMax = 4.0f;
    private float spawnIntervalMin = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, RandomNumber(spawnIntervalMin, spawnIntervalMax));
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(RandomNumber(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int ballIndex = RandomNumber(0, ballPrefabs.Length - 1);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[0].transform.rotation);
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
