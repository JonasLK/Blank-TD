using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public bool placing;
    public Vector3 placePos;
    public GameObject blueprint;
    public GameObject lastPlacedTower;
    public int towerToPlace;
    public List<GameObject> preTowers = new List<GameObject>();
    public List<GameObject> towers = new List<GameObject>();
    public MoneyManager moneyManager;

    public void Start()
    {
        moneyManager = GameObject.Find("MoneyManager").GetComponent<MoneyManager>();
    }

    public void BlueprintTower(int newTowerToPlace)
    {
        placing = true;
        towerToPlace = newTowerToPlace;
        Instantiate(preTowers[towerToPlace], placePos, Quaternion.identity);
        blueprint = GameObject.FindGameObjectWithTag("TowerA");
    }

    public void ChangeBluePrintPosition(Vector3 newPos)
    {
        placePos = newPos;
        if(placing == true)
        {
        blueprint.transform.position = newPos;
        }
    }

    public void Update()
    {
        if(placing == true && Input.GetMouseButtonDown(0) && moneyManager.money >= towers[towerToPlace].GetComponent<OnTower>().cost)
        {
            Destroy(blueprint);
            lastPlacedTower = Instantiate(towers[towerToPlace], placePos, Quaternion.identity);
            moneyManager.money -= towers[towerToPlace].GetComponent<OnTower>().cost;
            placing = false;
        }

        if (placing == true && Input.GetMouseButtonDown(1))
        {
            placing = false;
            Destroy(blueprint);
        }
    }
}