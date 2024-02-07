using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    [SerializeField] Slider health;
    
    
    public void UpdateHealthBar(float Current, float max)
    {
        health.value = Current / max;
    }
    void Start()
    {
      
        
    }

    
}
