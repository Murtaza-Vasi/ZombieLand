using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWave : MonoBehaviour
{
    public GameObject TheEnemy;
	public GameObject TheCapsule;
	public float xPos;
	public float zPos;
	public int EnemyCount=0;
	
	void OnTriggerEnter(Collider col)
	{
		StartCoroutine(EnemyInstantiate());
	}
	
    public IEnumerator EnemyInstantiate()
	{
		while(EnemyCount < 15){
			
			xPos = TheCapsule.transform.position.x + Random.Range(1,25);
			zPos = TheCapsule.transform.position.z + Random.Range(1,25);
			Instantiate(TheEnemy,new Vector3(xPos,10.15f,zPos),Quaternion.identity);
			yield return new WaitForSeconds(1);
			EnemyCount++;
		}
	}
}
