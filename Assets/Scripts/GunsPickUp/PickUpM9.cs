using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpM9 : MonoBehaviour
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
			PickUp9mm();
		}  
    }

    void PickUp9mm()
    {
        if (CheckGunPicked.GunPicked == false)
        {
			this.gameObject.SetActive(false);
            CheckGunPicked.GunPicked = true;
			CheckGunPicked.GunPickedTracker[0] = true;
            transform.position = new Vector3(0, -1000, 0);
            FakeGun.SetActive(false);
            RealGun.SetActive(true);
            TypeOfGun.AssignName("M9");
            Ammo.MaxAssignAmmo(12,60);
            GunDamage.SetGunDamage(7);
        }
    }
}
