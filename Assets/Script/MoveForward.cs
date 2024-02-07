using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    
    public float speed;
    public float destroy = 10.0f;
    public float startTime;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //moves the animals forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        float elapsedTime = Time.time - startTime;
        if (elapsedTime >= destroy)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);

        }

    }

}
