using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeSnap : MonoBehaviour
{
    public Vector3 bTPosition;
    public bool track;

    void Start()
    {
        
    }

    void OnMouseEnter()
    {
        if(track == true)
        {
            bTPosition = transform.position;
        }
    }
}