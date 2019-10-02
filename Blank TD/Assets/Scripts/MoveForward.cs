using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public void Start()
    {

    }
    void Update()
    {
        gameObject.transform.Translate(transform.forward * Time.deltaTime);
    }
}