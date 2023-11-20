using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject spawner;

    void Start()
    {
        var interval = Random.Range(4f, 5f); //creates an enemy randomly between 4 and 5 seconds
        StartCoroutine(spawnEnemy(interval));
    }

    private IEnumerator spawnEnemy(float interval) //Starts a loop that every interval creates an enemy
    {
        yield return new WaitForSeconds(interval);
        GameObject enemy = EnemyPooler.SharedInstance.GetPooledEnemy(); //Calls an enemy from the EnemyPooler script
            if (enemy != null) {
                //Applies position, rotation and activates the called enemy
                enemy.transform.position = spawner.transform.position;
                enemy.transform.rotation = Quaternion.identity;
                enemy.SetActive(true);
            }
        StartCoroutine(spawnEnemy(interval));
    }
}
