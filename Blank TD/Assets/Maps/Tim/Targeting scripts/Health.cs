using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float maxHealth;
    public float currentHealth;

    public GameObject healthbarPrefab;
    GameObject handy;

    public void Start()
    {
        currentHealth = maxHealth;
        handy = Instantiate(healthbarPrefab, Vector3.zero, Quaternion.identity);

    }

    public void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Death();
        }
    }

    public void Damage(float damage)
    {
        currentHealth -= damage;
        if(currentHealth==0)
        {
            Death();
        }
    }

   void Death()
    {
        Destroy(gameObject);
    }

}
