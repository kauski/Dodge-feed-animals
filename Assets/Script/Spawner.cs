using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabAnimals;
    private readonly int min = 0;
    public float spawnDistance = 20.0f;
    public float spawnRangeX = 20.0f;
    public float spawnRangeXx = -20.0f;
    public float spawnTimer = 2.0f;
    public float startTimer = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startTimer, spawnTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    void SpawnRandomAnimal()
    {
        //animal spawner
        int animalIndex = RandomNumber(min, prefabAnimals.Length - 1);
        Vector3 spawnPos = new Vector3(RandomNumber(spawnRangeXx, spawnRangeX), 0, spawnDistance);

        Instantiate(prefabAnimals[animalIndex], spawnPos,
            prefabAnimals[RandomNumber(min, prefabAnimals.Length - 1)].transform.rotation);
    }
    //random number generator int/float/double
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
