using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float explosiveRadius;
    public float damage;
    
    public void OnCollisionEnter(Collision c)
    {
        gameObject.GetComponent<SphereCollider>().radius = explosiveRadius;
        Destroy(gameObject,0.1f);
    }
}
