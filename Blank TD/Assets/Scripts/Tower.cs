using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject tower;
    public GameObject buyTower;
    public float dpp;
    public float attackspeed;
    public int cost;
    public float range;
    public NodeSnap snap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        buyTower.transform.position = snap.bTPosition;
    }
}
