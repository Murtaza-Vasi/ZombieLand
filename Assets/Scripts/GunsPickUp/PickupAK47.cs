using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupAK47 : MonoBehaviour
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
					CheckGunPicked.GunPickedTracker[i] = false;
					CheckGunPicked.GunPicked = false;
					Ammo.CurrentAmmo = 0;
					Ammo.LoadedAmmo = 0;
				}
			}
		}
		else 
		{
			PickUpAK47();
		}
    }

	void PickUpAK47() 
    {
		CheckGunPicked.GunPicked = true;
		CheckGunPicked.GunPickedTracker[3] = true;
        transform.position = new Vector3(0, -1000, 0);
        FakeGun.SetActive(false);
        RealGun.SetActive(true);
        TypeOfGun.AssignName("AK-47");
        Ammo.MaxAssignAmmo(25, 75);
        GunDamage.SetGunDamage(17);
        
    }
}
