using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject spawner;
    public int enemyAmount;
    public int enemySelector;
    public int enemieStrengthGuage;
    public float roundTimer;
    public float secondsBetweenEnemySpawns;

    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("EnemySpawner");
    }

    public void WaveStart()
    {
        StartCoroutine(Wave());
    }
    
    public IEnumerator Wave()
    {
        for (int i = 0; i < enemyAmount; i++)
        {
            EnemySelect();
            Instantiate(enemies[enemySelector], spawner.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(secondsBetweenEnemySpawns);
        }
    }

    public void EnemySelect()
    {
        enemySelector = Random.Range(0, enemieStrengthGuage);
    }
}
/* make a random enemy picker that gets access to more enemies the further you get into the rounds (could also replace old ones with better ones)
 * also need to increase amount of enemies
*/