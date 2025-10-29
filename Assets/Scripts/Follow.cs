using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;      
    public float speed = 2f;      
    public float followRange = 5f; 
    void Update()

    {
        float distance = Vector2.Distance(transform.position, player.position);
        if (distance < followRange)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        }

    }

}
