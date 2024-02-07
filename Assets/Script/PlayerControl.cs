using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject pizzaSlice;
    public float horizontalInput;
    public float verticalInput;
    public float speed = 5.0f;
    public float pushBack = 1.5f;
    public float outOfBounds = 18.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moves player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        //Out of bounds
        if (transform.position.z < 0)
        {
            transform.Translate(Vector3.forward * pushBack);
        }

        if (transform.position.z > 18.30f)
        {
            transform.Translate(Vector3.forward * pushBack * -1);
        }

       if (transform.position.x >= outOfBounds)
        {
            transform.Translate(Vector3.right * pushBack * -1);
        }

       if (transform.position.x <= outOfBounds * -1)
        {
            transform.Translate(Vector3.right * pushBack);
        }

       //throw object
       if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(pizzaSlice, transform.position, pizzaSlice.transform.rotation);
        }
                
        }
    }

