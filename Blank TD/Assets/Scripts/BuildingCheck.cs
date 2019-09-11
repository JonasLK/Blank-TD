using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCheck : MonoBehaviour
{
    public GameObject turret;
    public TowerManager towerManage;
    public bool occupied;

    void Start()
    {
        towerManage = GameObject.Find("TowerManager").GetComponent<TowerManager>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (towerManage.lastPlacedTower.transform.position == gameObject.transform.position)
            {
                turret = towerManage.lastPlacedTower;
            }
        }

        if(turret != null)
        {
            occupied = true;
        }
    }
}