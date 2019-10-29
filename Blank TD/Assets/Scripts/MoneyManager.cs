using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public GameObject sellButton;
    public Manager manager;
    public TowerManager towerManager;
    public Text moneyDisplay;
    public Text sellButtonDisplay;
    public Text buyPriceDisplay;
    public float money = 100;
    public float sellPrice;
    public int buyPrice;
    public bool noFakeStart;

    public void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
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

    void FakeStart()
    {
        moneyDisplay = GameObject.Find("MoneyDisplay").GetComponent<Text>();
        sellButton = manager.turnedOffGameObjects[1];
        sellButtonDisplay = sellButton.GetComponentInChildren<Text>();
        towerManager = manager.tower;
        buyPriceDisplay = manager.turnedOffGameObjects[0].GetComponent<Text>();
        UpdateMoneyDisplay();
    }

    public void UpdateMoneyDisplay()
    {
        moneyDisplay.text = "Money: $" + money.ToString();
    }

    public void SellPriceUpdate(int towerCost)
    {
        sellPrice = towerCost * 0.75f;
        sellButtonDisplay.text = "Sell Tower: + $" + sellPrice.ToString();
    }

    public void AddSoldTowerMoney()
    {
        Destroy(towerManager.lastSellingTower);
        money += sellPrice;
        UpdateMoneyDisplay();
        sellButton.SetActive(false);
    }

    public void CostPriceUpdate(int towerCost)
    {
        buyPrice = towerCost;
        buyPriceDisplay.text = "buy: $" + buyPrice.ToString();
    }
}
