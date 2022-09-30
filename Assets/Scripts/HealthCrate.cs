using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCrate : MonoBehaviour
{
    public void OnTriggerEnter(Collider Col)
	{
        if (GlobalHealth.PlayerHealth<100)
        {
            GlobalHealth.PlayerHealth += 20;
            if(GlobalHealth.PlayerHealth>100)
            {
                GlobalHealth.PlayerHealth = 100;
            }
            this.gameObject.SetActive(false);
        }
        
        //Debug.Log(CheckGunPicked.GunPicked);
    }
}

