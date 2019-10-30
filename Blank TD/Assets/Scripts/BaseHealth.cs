using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHealth : MonoBehaviour
{
    public float baseHealth;
    public int baseHealthInt;

    public void Damage(float enemyDamage)
    {
        baseHealth -= enemyDamage;
        baseHealthInt = Mathf.RoundToInt(baseHealth);
    }
    
    void Update()
    {
        
    }
}