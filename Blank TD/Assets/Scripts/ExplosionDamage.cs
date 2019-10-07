using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDamage : MonoBehaviour
{
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Explosive")
        {
            gameObject.GetComponent<Health>().Damage(c.gameObject.GetComponent<Explosion>().damage);
        }
    }
}
