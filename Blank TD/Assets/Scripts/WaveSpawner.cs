using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject spawner;
    public int enemyAmount;
    public int enemyAmountPlus;
    public int enemySelector;
    public int enemieStrengthGuageMax;
    public int enemieStrengthGuageMin;
    public int enemiesSpawnedThisWave;
    public float roundTimer;
    public float secondsBetweenEnemySpawns;
    public bool waveActive;
    private int fiveTwo;
    private int onefive;

    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("EnemySpawner");
        WaveStart();
    }

    public void WaveStart()
    {
        if(waveActive == false)
        {
            StartCoroutine(Wave());
        }
    }
    
    public IEnumerator Wave()
    {
        waveActive = true;
        for (int i = 0; i < enemyAmount; i++)
        {
            enemiesSpawnedThisWave += 1;
            EnemySelect();
            Instantiate(enemies[enemySelector], spawner.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(secondsBetweenEnemySpawns);
        }
    }

    public void EnemySelect()
    {
        enemySelector = Random.Range(enemieStrengthGuageMin, enemieStrengthGuageMax);
    }

    public void L()
    {
        onefive = Random.Range(0, 6);
        fiveTwo = Random.Range(0, 3);
        if(onefive == 5)
        {
            enemieStrengthGuageMin += 1;
            enemieStrengthGuageMax += 1;
        }
        if(fiveTwo == 1)
        {
            enemyAmount += 1;
        }else if(fiveTwo == 2)
        {
            enemyAmount += 2;
        }
    }

    public void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            L();
        }*/
        if(enemiesSpawnedThisWave == enemyAmount)
        {
            L();
            waveActive = false;
            enemiesSpawnedThisWave = 0;
        }
    }
}
/* make a random enemy picker that gets access to more enemies the further you get into the rounds (could also replace old ones with better ones)
 * also need to increase amount of enemies
*/