using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseHealth : MonoBehaviour
{
    public float maxBasehealth;
    public float healthScale;
    private float baseHealth;
    private int baseHealthInt;
    public GameObject healthAndText;
    public GameObject defeatScreen;
    public Transform healthBar;
    public Text healthText;
    public Manager manager;

    public void Start()
    {
        manager = GameObject.FindGameObjectWithTag("DefeatScreen").GetComponent<Manager>();
        healthAndText = GameObject.FindGameObjectWithTag("HealthAndText");
        baseHealth = maxBasehealth;
        healthBar = healthAndText.transform.GetChild(0);
        healthText = healthAndText.GetComponentInChildren<Text>();
        healthScale = 1;
    }

    public void Damage(float enemyDamage)
    {
        baseHealth -= enemyDamage;
        baseHealthInt = Mathf.RoundToInt(baseHealth);
        if(baseHealthInt <= 0)
        {
            baseHealthInt = 0;
            Defeat();
        }
        UpdateHealth(enemyDamage * 0.001f);
    }
    
    public void UpdateHealth(float enemyDamage)
    {
        if(baseHealthInt <= 0)
        {
            healthBar.localScale = new Vector3(0, healthBar.localScale.y, healthBar.localScale.z);
        }
        else
        {
            healthBar.localScale = new Vector3(healthScale - enemyDamage, healthBar.localScale.y, healthBar.localScale.z);
            healthScale -= enemyDamage;
        }
        healthText.text = Mathf.RoundToInt(baseHealthInt).ToString() + "/" + maxBasehealth.ToString();
    }

    public void Defeat()
    {
        Time.timeScale = 0;
        manager.turnedOffGameObjects[4].SetActive(true);
    }
}