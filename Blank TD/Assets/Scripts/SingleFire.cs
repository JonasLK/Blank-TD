using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleFire : MonoBehaviour
{
    public float firerate;
    public float timer;
    public GameObject bullet;
    public GameObject firepoint;
    public Targeting targeting;
    void Start()
    {
        targeting = gameObject.GetComponentInParent<Targeting>();
    }

    void Update()
    {
        //if (targeting.targeting == true)
        {
            timer -= Time.deltaTime;
        }

        if(timer < 0)
        {
            bullet = Instantiate(bullet, firepoint.transform.position, firepoint.transform.rotation);
            timer = firerate;
        }
    }
}
