﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targeting1 : MonoBehaviour
{
    public Transform target;
    public float range = 20f;
    public float attackDelay;
    public float attackSpeed;
    public float damage;
    public ParticleSystem parti;
    public string enemyTag = "Enemy";

    public Transform Rotatingtop;

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            float enemyDistance = Vector3.Distance(transform.position, enemy.transform.position);
            if (enemyDistance < shortestDistance)
            {
                shortestDistance = enemyDistance;
                nearestEnemy = enemy;
            }
        if (nearestEnemy != null && shortestDistance <= range)
            {
                target = nearestEnemy.transform;
            }
            else
            {
                target = null;
            }
        }
    }


    void Update()
    {
        if (target == null)
            return;

        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = lookRotation.eulerAngles;
        Rotatingtop.rotation = Quaternion.Euler(0f, rotation.y+90f, 0f);
    
        if (target != null)
        {
            if (attackDelay > attackSpeed)
            {
                Attack();
                attackDelay = 0;
            }
            attackDelay += Time.deltaTime;
        }


    }

    void Attack()
    {
        target.GetComponentInParent<Health>().Damage(damage);
        parti.Play();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }

}
