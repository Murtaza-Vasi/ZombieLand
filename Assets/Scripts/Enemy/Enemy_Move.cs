using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject TheEnemy;
    public float EnemySpeed;
    public bool MoveTrigger;

    // Update is called once per frame
    void Update()
    {
        if(MoveTrigger == true)
        { 
            EnemySpeed = 0.01f;
            transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
        }
    }
}
