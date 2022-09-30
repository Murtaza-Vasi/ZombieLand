using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadShotgun : MonoBehaviour
{
    //public AudioSource ReloadSound;
    public int NumberOfReload=0;
    //public GameObject ReloadAnim; 
    public GameObject MechanicsObj;
    public int ClipAmmo;                       // Ammo in the gun
    public int ReservedAmmo;                   // Total ammo left for reload
    public int ReloadAvailable;

    void Update()
    {
        ClipAmmo = Ammo.LoadedAmmo;
        ReservedAmmo = Ammo.CurrentAmmo;

        if (ReservedAmmo == 0)
        {
            ReloadAvailable = 0;
        }
        else
        {
            ReloadAvailable = Ammo.MaxInternalAmmo - ClipAmmo;
        }

        if (Input.GetButtonDown("Reload"))
        {
            if (ReloadAvailable >= 1)
            {
                if (ReservedAmmo <= ReloadAvailable)                // Reloads the gun even if the bullets present r not enough to completely fill the clip
                {                                                   // i.e. if the clip has capacity of 10 bullets and there r 3 bullete in the gun
                    Ammo.LoadedAmmo += ReservedAmmo;                //      and there r only 5 bullets in the reserve the it will load only 5 bullets
                    Ammo.CurrentAmmo -= ReservedAmmo;               //      and will reload them, rather than reloading 7 bullets which r not present
                    NumberOfReload = Math.Abs(ClipAmmo - 12);
                    Reload(NumberOfReload);
                }
                else
                {
                    Ammo.LoadedAmmo += ReloadAvailable;
                    Ammo.CurrentAmmo -= ReloadAvailable;
                    NumberOfReload = Math.Abs(ClipAmmo - 12);
                    Reload(NumberOfReload);
                }
            }
            StartCoroutine(EnableScripts());
        }
    }

    IEnumerator EnableScripts()
    {
        yield return new WaitForSeconds(1);
        MechanicsObj.SetActive(true);
    }

    void Reload(int NumberOfReloads)
    {
        MechanicsObj.SetActive(false);
        //ReloadSound.Play();
        for(int i = 0; i < NumberOfReloads; i++)
        {
            StartCoroutine(PlayAnim(i));
        }
    }

    IEnumerator PlayAnim(int i)
    {
        Debug.Log("Reload " + i);
        this.GetComponent<Animation>().Play("ShotgunReload");
        yield return new WaitForSeconds(1);
    }
}
