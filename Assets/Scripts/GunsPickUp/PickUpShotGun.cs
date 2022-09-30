using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpShotGun : MonoBehaviour
{
    public float TheDistance = PlayerCasting.DistanceFromTarget;
    public GameObject FakeGun;
    public GameObject RealGun;
	public GameObject[] realGuns;
	public GameObject[] fakeGuns;
    
	public void OnTriggerEnter(Collider Col)
    {
		if(CheckGunPicked.GunPicked == true)
		{
			for(int i=0;i<5;i++)
			{
				if(CheckGunPicked.GunPickedTracker[i] == true)
				{
					realGuns[i].SetActive(false);
					fakeGuns[i].SetActive(true);
					CheckGunPicked.GunPickedTracker[i] = false;
					CheckGunPicked.GunPicked = false;
					Ammo.CurrentAmmo = 0;
					Ammo.LoadedAmmo = 0;
				}
			}
		}
		else if(CheckGunPicked.GunPicked == false)
		{
			PickUpShotgun();
		}
	}

    void PickUpShotgun()
    {
        if (CheckGunPicked.GunPicked == false)
        {
			
			this.gameObject.SetActive(false);
            CheckGunPicked.GunPicked = true;
			CheckGunPicked.GunPickedTracker[2] = true;
            transform.position = new Vector3(0, -1000, 0);
            FakeGun.SetActive(false);
            RealGun.SetActive(true);
            TypeOfGun.AssignName("ShotGun");
            Ammo.MaxAssignAmmo(7, 21);
            GunDamage.SetGunDamage(20);
        }
    }
}

