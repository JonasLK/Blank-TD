using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTower : MonoBehaviour
{
    public float dpp;
    public float attackspeed;
    public int cost;
    public float sellPrice;
    public float range;
    public GameObject sellButton;
    public MoneyManager moneyManager;
    public TowerManager towermanager;
    public bool sellButtonActive;

    void Start()
    {
        moneyManager = GameObject.Find("MoneyManager").GetComponent<MoneyManager>();
        towermanager = GameObject.Find("TowerManager").GetComponent<TowerManager>();
        sellButton = GameObject.Find("Manager").GetComponent<Manager>().sellButton;
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            towermanager.SellingTower(gameObject);
            if (sellButtonActive == false)
            {
                moneyManager.SellPriceUpdate(cost);
                sellButton.SetActive(true);
                sellButtonActive = true;
            }
            else
            {
                sellButton.SetActive(false);
                sellButtonActive = false;
            }
        }
    }
}
