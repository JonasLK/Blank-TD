using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeSnap : MonoBehaviour
{
    public Material mater;
    public Color ogColor;
    public Color highlightColor;
    public SnapManager snapManager;
    public BuildingCheck ownBuildingCheck;

    void Start()
    {
        mater = GetComponent<Renderer>().material;
        ogColor = mater.color;
        ownBuildingCheck = gameObject.GetComponent<BuildingCheck>();
        snapManager = GameObject.FindGameObjectWithTag("SnapManager").GetComponent<SnapManager>();
    }

    void OnMouseEnter()
    {
        if(ownBuildingCheck.occupied == false)
        {
            mater.color = highlightColor;
            snapManager.Snap(transform.position);
            snapManager.LastNode(gameObject);
        }
    }

    public void OnMouseExit()
    {
        mater.color = ogColor;
    }
}