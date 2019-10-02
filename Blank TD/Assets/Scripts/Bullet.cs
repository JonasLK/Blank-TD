using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Targeting targeting;
    void Start()
    {
        targeting = GetComponentInParent<Targeting>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targeting.target);
        transform.position += Vector3.forward * Time.deltaTime;
    }
}
