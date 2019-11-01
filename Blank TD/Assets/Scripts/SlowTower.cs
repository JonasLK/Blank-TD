using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTower : MonoBehaviour
{
    public List<GameObject> enemiesInRange;
    public float range;
    private float attackDelay;
    public float attackSpeed;
    public float slowTime;
    public float slowAmount;
    //public ParticleSystem partic;
    public float damage;

    private void Awake()
    {
        GetComponent<SphereCollider>().radius = range;
    }

    void Update()
    {
        if(enemiesInRange.Count > 0)
        {
            if (attackDelay > attackSpeed)
            {
                Attack();
                attackDelay = 0;
            }
            attackDelay += Time.deltaTime;
        }
    }

    public void AddTarget(GameObject enemy)
    {
        enemiesInRange.Add(enemy);
    }

    public void RemoveTarget(GameObject enemy)
    {
        foreach (GameObject enemies in enemiesInRange)
        {
            if(enemies == enemy)
            {
                enemiesInRange.Remove(enemies);
            }
        }
    }


    void Attack()
    {
        foreach (GameObject enemies in enemiesInRange)
        {
            enemies.GetComponentInParent<Health>().Damage(damage);
            enemies.GetComponentInParent<Enemy_Test>().Slowed(slowTime, slowAmount);
        }
        //partic.Play();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}