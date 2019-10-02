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
        handy.transform.SetParent(UIManager.healthCanvas.transform);
    }

    public void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Death();
        }
    }

    public void LateUpdate()
    {
        handy.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 1.5f, 0));
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
