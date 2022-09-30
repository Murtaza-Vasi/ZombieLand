using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFollow : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject TheEnemy;
    public static float EnemySpeed;
    public int AttackTrigger;
    public RaycastHit Shot;
    public float TargetDistance;
    public int AllowedRange = 10;
    public int IsAttacking;


    void Update()
    {
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out Shot))
        {
            transform.LookAt(ThePlayer.transform);
            TargetDistance = Shot.distance;
            if(TargetDistance < AllowedRange)
            {
                EnemySpeed = 2.5f;
                if(AttackTrigger == 0)
                {
					float xpos,zpos;
                    TheEnemy.GetComponent<Animation>().Play("Walking");
					xpos = ThePlayer.transform.position.x;
					zpos = ThePlayer.transform.position.z;
                    transform.position = Vector3.MoveTowards(transform.position,new Vector3(xpos,10.18f,zpos),EnemySpeed * Time.deltaTime);
                }
            }
            else
            {
                EnemySpeed = 0;
                TheEnemy.GetComponent<Animation>().Play("Idle");
            }
        }
        if(AttackTrigger == 1)
        {
            if(IsAttacking==0)
            {
                StartCoroutine(EnemyDamage());
            }
            EnemySpeed = 0;
            TheEnemy.GetComponent<Animation>().Play("Attacking");
        }
    }

    void OnTriggerEnter()
    {
        AttackTrigger = 1;
    }

    void OnTriggerExit()
    {
        AttackTrigger = 0;
    }
    IEnumerator EnemyDamage()
    {
        IsAttacking = 1;
        yield return new WaitForSeconds(0.9f);
        yield return new WaitForSeconds(1);
        GlobalHealth.PlayerHealth -= 5;
        IsAttacking = 0;
    }
}
