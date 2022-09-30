using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public AudioSource AmmoPickUpSound;
    public void OnTriggerEnter(Collider col)
    {
        if (CheckGunPicked.GunPicked == true)
        {
			if (Ammo.CurrentAmmo < Ammo.MaxAmmo)
            {
                AmmoPickUpSound.Play();
                if (Ammo.LoadedAmmo == 0)
                {
                    Ammo.LoadedAmmo += Ammo.MaxInternalAmmo;                      // Ammo in the gun
                }
                else
                {
                    Ammo.CurrentAmmo += Ammo.MaxInternalAmmo;                    // Magazine of gun
                }
                this.gameObject.SetActive(false);
            }

        }
    }
}
