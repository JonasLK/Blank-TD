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
    public GameObject defeatScreenParent;
    public Transform healthBar;
    public Text healthText;
    public Manager manager;
    public bool noFakeStart;

    public void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        defeatScreenParent = GameObject.FindGameObjectWithTag("DefeatScreen");
        healthAndText = GameObject.FindGameObjectWithTag("HealthAndText");
        baseHealth = maxBasehealth;
        healthBar = healthAndText.transform.GetChild(0);
        healthText = healthAndText.GetComponentInChildren<Text>();
        healthScale = 1;
    }

    public void Update()
    {
        if (noFakeStart == false)
        {
            if (manager.arrayFilled == true)
            {
                FakeStart();
                noFakeStart = true;
            }
        }
    }

    public void FakeStart()
    {
        defeatScreen = manager.turnedOffGameObjects[3];
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
        defeatScreen.SetActive(true);
        GameObject.FindGameObjectWithTag("OtherCanvas").SetActive(false);
        Time.timeScale = 0;
        defeatScreenParent.GetComponent<DefeatScreen>().UpdateRoundsSurvived();
    }
}