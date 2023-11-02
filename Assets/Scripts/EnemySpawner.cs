using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float interval;

    void Start()
    {
        StartCoroutine(spawnEnemy(interval));
    }

    private IEnumerator spawnEnemy(float interval)
    {
        yield return new WaitForSeconds(interval);
        GameObject enemy = EnemyPooler.SharedInstance.GetPooledEnemy();
            if (enemy != null) {
                enemy.transform.position = new Vector3(Random.Range(-10f, 10), Random.Range(-10f, 10f), 0);
                enemy.transform.rotation = Quaternion.identity;
                enemy.SetActive(true);
            }
        
        
        //Get(enemy, new Vector3(Random.Range(-10f, 10), Random.Range(-10f, 10f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval));
    }
}
