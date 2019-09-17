using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public MoneyManager money;
    public TowerManager tower;
    public SnapManager snap;
    public GameObject sellButton;

    void Start()
    {
        money = GameObject.Find("MoneyManager").GetComponent<MoneyManager>();
        tower = GameObject.Find("TowerManager").GetComponent<TowerManager>();
        snap = GameObject.Find("SnapManager").GetComponent<SnapManager>();
        sellButton = GameObject.FindGameObjectWithTag("SellButton");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
