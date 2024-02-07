using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] HealthBar healthBar;
    private int score = 0;
    private int lives = 3;
    private int maxLives = 3;
    private void Start()
    {
        healthBar = GameObject.Find("HealthBar").GetComponent<HealthBar>();
    }

    public void AddLives(int add)
    {
        //update health
       
        lives += add;
        healthBar.UpdateHealthBar(lives, maxLives);
       
        if (lives <= 0)
        {
            Debug.Log("Game Over");
            lives = 0;
        }
        Debug.Log("lives = " + lives);
    }

    public void AddScore(int add)
    {
        score += add;
        Debug.Log("Score = " + score);
    }
    
}
