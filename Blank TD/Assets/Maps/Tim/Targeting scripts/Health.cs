using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float maxHealth;
    public float currentHealth;
    public float damage;
    
    public GameObject healthbarfab;
    GameObject handy;
    Image handyImg;

public void Start()
{
        currentHealth = maxHealth;
        handy = Instantiate(healthbarfab, Vector3.zero, Quaternion.identity);
        handy.transform.SetParent(UIManager.healthCanvas.transform);
        handyImg = handy.transform.Find("HealthBar").transform.Find("HealthBarEmpty").GetComponent<Image>();
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
        handy.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(2, 1.5f, 0));
    }

    public void Damage(float damage)
    {
        currentHealth -= damage;
        handyImg.fillAmount = currentHealth/maxHealth;
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            Death();
        }
    }

    void Death()
    {
        Destroy(gameObject);
        //Destroy(handy);
    }

    public void OnTriggerEnter(Collider o)
    {
        if(o.gameObject.tag == "Base")
        {
            o.gameObject.GetComponent<BaseHealth>().Damage(damage);
            Death();
        }
    }
}
