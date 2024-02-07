using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AggressiveSpawn : MonoBehaviour
{
    public float speed = 5.0f;
    public float destroy = 10.0f;
    public float startTime = 2.0f;
    private GameManager gameManager;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        startTime = Time.time;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
        //move forward and delete after elapsed time
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        float elapsedTime = Time.time - startTime;
        if (elapsedTime >= destroy)
        {
            
            Destroy(gameObject);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
        }
    }

}
