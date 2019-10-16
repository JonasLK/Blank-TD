using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TargetingChain : MonoBehaviour
{
    public Transform target;
    public float range = 20f;
    public float attackDelay;
    public float attackSpeed;
    public ParticleSystem partic;
    public ParticleSystem chains;
    public float damage;
    public float damageChain;

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
        Rotatingtop.rotation = Quaternion.Euler(0f, rotation.y + 90f, 0f);

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
        partic.Play();

    }

    public void ChainDamg(Transform pivot, float damg, int jumpsLeft)
    {
        // Do damg, check if dead. done
        // Make sure you do the next, even if dead == true.
        // Check targets in range of pivot.
        // Get closest target.
        // Call ChainDamg for that closest target, reduce jumpsLeft with 1;

        //var nClosest = myTransforms.OrderBy(t => (t.position - referencePos).sqrMagnitude)
        //                   .Take(3)   //or use .FirstOrDefault();  if you need just one
        //                   .ToArray(); Transform GetClosestEnemy(Transform[] enemies)
        //{
        //    Transform tMin = null;
        //    float minDist = Mathf.Infinity;
        //    Vector3 currentPos = transform.position;
        //    foreach (Transform t in enemies)
        //    {
        //        float dist = Vector3.Distance(t.position, currentPos);
        //        if (dist < minDist)
        //        {
        //            tMin = t;
        //            minDist = dist;
        //        }
        //    }
        //    return tMin;
        //}
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }

}
