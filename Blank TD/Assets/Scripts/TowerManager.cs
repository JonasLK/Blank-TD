using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public bool placing;
    public Vector3 placePos;
    public GameObject blueprint;
    public GameObject lastPlacedTower;
    public GameObject lastHoveredNode;
    public GameObject lastSellingTower;
    public int towerToPlace;
    public List<GameObject> preTowers = new List<GameObject>();
    public List<GameObject> towers = new List<GameObject>();
    public MoneyManager moneyManager;
    public Manager manager;
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
        if(placing == true && Input.GetMouseButtonDown(0))
        {
            if(moneyManager.money >= towers[towerToPlace].GetComponent<OnTower>().cost)
            {
                if(lastHoveredNode.GetComponent<BuildingCheck>().occupied == false)
                {
                    Destroy(blueprint);
                    lastPlacedTower = Instantiate(towers[towerToPlace], placePos, Quaternion.identity);
                    moneyManager.money -= towers[towerToPlace].GetComponent<OnTower>().cost;
                    moneyManager.UpdateMoneyDisplay();
                    manager.turnedOffGameObjects[0].SetActive(false);
                    placing = false;
                }
            }
            else
            {
                Destroy(blueprint);
            }
        }

        if (placing == true && Input.GetMouseButtonDown(1))
        {
            placing = false;
            manager.turnedOffGameObjects[0].SetActive(false);
            Destroy(blueprint);
        }
    }

    public void FakeStart()
    {
        moneyManager = manager.money;
    }

    public void BlueprintTower(int newTowerToPlace)
    {
        placing = true;
        towerToPlace = newTowerToPlace;
        Instantiate(preTowers[towerToPlace], placePos, Quaternion.identity);
        moneyManager.CostPriceUpdate(towers[towerToPlace].GetComponent<OnTower>().cost);
        blueprint = GameObject.FindGameObjectWithTag("PreTower");
        manager.turnedOffGameObjects[0].SetActive(true);
    }

    public void ChangeBluePrintPosition(Vector3 newPos)
    {
        placePos = newPos;
        if(placing == true && blueprint != null)
        {
            blueprint.transform.position = placePos;
        }
    }

    public void SellingTower(GameObject sellingTower)
    {
        lastSellingTower = sellingTower;
    }
}