using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleHealth : MonoBehaviour
{
	public int Capsule_Health = 50;
	public GameObject Gun;
	
	public void DeductPointsCapsule(int DamageAmount)
    {
        Capsule_Health -= DamageAmount;
		
		if(Capsule_Health <= 0)
		{
			Debug.Log(Capsule_Health);
			Destroy(gameObject);
			Gun.SetActive(true);
		}
    }
}
