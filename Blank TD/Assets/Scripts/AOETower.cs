using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOETower : MonoBehaviour
{
    public GameObject explosive;
    public Transform target;
    public float range;
    public float fireTimer;
    public float attackSpeed;
    public float damage;
    public float explosiveRadius;
    public float dropHeight;
    public Vector3 explosiveSpawn;

    public string enemyTag = "Enemy";

    public Transform Rotatingtop;

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
        explosive.GetComponent<Explosion>().explosiveRadius = explosiveRadius;
        explosive.GetComponent<Explosion>().damage = damage;
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
        {
            return;
        }
        
        if (target != null)
        {
            if (fireTimer > attackSpeed)
            {
                Attack();
                fireTimer = 0;
            }
            fireTimer += Time.deltaTime;
        }
    }

    void Attack()
    {
        explosiveSpawn = new Vector3(target.transform.position.x, target.transform.position.y + dropHeight, target.transform.position.z);
        Instantiate(explosive,explosiveSpawn,Quaternion.identity);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }

}
