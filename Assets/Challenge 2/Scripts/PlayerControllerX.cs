using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    
    public float spawnDelay = 2.0f;
    private float nextSpawnTime = 0.0f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextSpawnTime)
        {
            SpawnDog();
            nextSpawnTime = Time.time + spawnDelay;
        }
    }

    void SpawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

    }
    
}
