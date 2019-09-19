using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.position += Vector3.forward * Time.deltaTime;
    }
}
