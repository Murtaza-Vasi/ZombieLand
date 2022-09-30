using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunThrow : MonoBehaviour
{
    public GameObject FakeGun;
	public GameObject RealGun;
	
	public Vector3 position;
	public Vector3 offset = new Vector3(-3.06f,1.37f,-7.38f);
	//public float offset;
	
	void Update()
	{
		if(Input.GetButtonDown("Throw"))
		{
			if(CheckGunPicked.GunPicked == true)
			{
				position = RealGun.transform.position;
				RealGun.SetActive(false);
				
				FakeGun.transform.position = position + offset;
				FakeGun.SetActive(true);
			}
		}
	}
}
