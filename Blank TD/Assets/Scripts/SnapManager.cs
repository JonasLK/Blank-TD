using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapManager : MonoBehaviour
{
    public TowerManager towerManager;

    private void Start()
    {
        towerManager = GameObject.Find("TowerManager").GetComponent<TowerManager>();
    }

    public void Snap(Vector3 lastSnap)
    {
        towerManager.ChangeBluePrintPosition(lastSnap);
    }

    public void LastNode(GameObject lastNode)
    {
        towerManager.lastHoveredNode = lastNode;
    }
}
