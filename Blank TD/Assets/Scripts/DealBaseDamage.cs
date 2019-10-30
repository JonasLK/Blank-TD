using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealBaseDamage : MonoBehaviour
{
    public float damage;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.tag == "Base")
        {
            c.gameObject.GetComponent<BaseHealth>().Damage(damage);
            Destroy(gameObject);
        }
    }
}