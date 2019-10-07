using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public MoneyManager money;
    public TowerManager tower;
    public SnapManager snap;
    public GameObject sellButton;
    public GameObject[] turnedOffGameObjects;
    public int turndeOffGameObjectsIndicator;

    void Start()
    {

        money = GameObject.Find("MoneyManager").GetComponent<MoneyManager>();
        tower = GameObject.Find("TowerManager").GetComponent<TowerManager>();
        snap = GameObject.Find("SnapManager").GetComponent<SnapManager>();
        sellButton = GameObject.FindGameObjectWithTag("SellButton");
    }

    public void TurnedOffGameObject(GameObject aboutToTurnOff)
    {
        turnedOffGameObjects[turndeOffGameObjectsIndicator] = aboutToTurnOff;
        turndeOffGameObjectsIndicator += 1;
    }
}