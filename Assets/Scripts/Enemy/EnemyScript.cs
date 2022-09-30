using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public static int EnemyHealth = 10;
	public GameObject TheEnemy;
    public void DeductPoints(int DamageAmount)
    {	
        EnemyHealth -= DamageAmount;
		
		if(EnemyHealth <= 0)
        {
            TheEnemy.GetComponent<Animation>().Play("Dying");
            enemyDead();
        }
    }

	void enemyDead(){
		Destroy(gameObject);
	}
	
    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(2);
    }
}
