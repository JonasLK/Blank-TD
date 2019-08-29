using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towers : MonoBehaviour
{
    public Tower tower;
    public NodeSnap node;
    void Start()
    {
        
    }

    public void BuyTower()
    {
        //if(money >= tower.cost)
        //{
            node.track = true;
            Instantiate(tower.buyTower, node.bTPosition, Quaternion.identity);

        //}
    }
}