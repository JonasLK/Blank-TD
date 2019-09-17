using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public GameObject sellButton;
    public TowerManager towerManager;
    public Text moneyDisplay;
    public Text sellButtonDisplay;
    public float money = 100;
    public float sellPrice;

    void Start()
    {
        moneyDisplay = GameObject.Find("MoneyDisplay").GetComponent<Text>();
        sellButton = GameObject.Find("Manager").GetComponent<Manager>().sellButton;
        sellButtonDisplay = sellButton.GetComponentInChildren<Text>();
        towerManager = GameObject.Find("Manager").GetComponent<Manager>().tower;
    }

    void Update()
    {
        moneyDisplay.text = "Money: " + money.ToString();
        sellButtonDisplay.text = "Sell Tower: + $" + sellPrice.ToString();
    }

    public void SellPriceUpdate(int towerCost)
    {
        sellPrice = towerCost * 0.75f;
    }

    public void AddSoldTowerMoney()
    {
        Destroy(towerManager.lastSellingTower);
        money += sellPrice;
        sellButton.SetActive(false);
    }
}
