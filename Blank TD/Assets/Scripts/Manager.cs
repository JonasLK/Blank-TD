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
    public bool arrayFilled;

    void Start()
    {
        money = GameObject.FindGameObjectWithTag("MoneyManager").GetComponent<MoneyManager>();
        tower = GameObject.FindGameObjectWithTag("TowerManager").GetComponent<TowerManager>();
        snap = GameObject.FindGameObjectWithTag("SnapManager").GetComponent<SnapManager>();
    }

    public void TurnedOffGameObject(GameObject aboutToTurnOff,int indexNumber)
    {
        turnedOffGameObjects[indexNumber] = aboutToTurnOff;
    }

    public void Update()
    {
        if(turnedOffGameObjects[0] != null && turnedOffGameObjects[1] != null && turnedOffGameObjects[2] != null)
        {
            arrayFilled = true;
        }
    }
}