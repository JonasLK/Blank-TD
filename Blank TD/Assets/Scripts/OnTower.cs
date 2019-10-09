using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTower : MonoBehaviour
{
    public int cost;
    public GameObject sellButton;
    public Manager manager;
    public MoneyManager moneyManager;
    public TowerManager towermanager;
    public bool sellButtonActive;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        moneyManager = manager.money;
        towermanager = manager.tower;
        sellButton = manager.turnedOffGameObjects[1];
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            towermanager.SellingTower(gameObject);
            if (sellButtonActive == false)
            {
                moneyManager.SellPriceUpdate(cost);
                moneyManager.UpdateMoneyDisplay();
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
