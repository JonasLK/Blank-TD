﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffGameobject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Manager").GetComponent<Manager>().TurnedOffGameObject(gameObject);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
