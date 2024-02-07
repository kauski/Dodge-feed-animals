using UnityEngine;

public class MeatRotate : MonoBehaviour
{

    public float rotateSpeed = 5.0f;
    public float forwardSpeed = 10.0f;
    public float destroy = 30.0f;
    private float startTime;
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

        //rotation and movement
        transform.Rotate(rotateSpeed * Time.deltaTime, 0, 0);
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed, Space.World);

        //destroys object after certain time
        float elapsedTime = Time.time - startTime;
        if (elapsedTime >= destroy)
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        //deletes projectile and object that it hit
        if (other.CompareTag("Player"))
        {

        }
        else
        {
            //other.GetComponent<AnimalHunger>().FeedAnimal(1);
           // gameManager.AddScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject);


        }
    }
}
