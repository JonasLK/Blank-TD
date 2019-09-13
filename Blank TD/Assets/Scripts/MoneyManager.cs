using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public Text moneyDisplay;
    public int money = 100;

    void Start()
    {
        moneyDisplay = GameObject.Find("MoneyDisplay").GetComponent<Text>();
    }

    void Update()
    {
        moneyDisplay.text = "Money: " + money.ToString();
    }
}
