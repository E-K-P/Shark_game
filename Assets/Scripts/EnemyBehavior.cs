using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float speed;
    public float health;
    public float damage;

    void Update()
    {
        //Movement towards the player character
        var player = GameObject.Find("Player");
        var distance = Vector3.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }
}

//test comment feel free to ignore
