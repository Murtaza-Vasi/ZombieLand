using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M9Reload : MonoBehaviour
{
    public AudioSource ReloadSound;
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
                    Reload();
                    
                }
                else
                {
                    Ammo.LoadedAmmo += ReloadAvailable;
                    Ammo.CurrentAmmo -= ReloadAvailable;
                    Reload();
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

    void Reload()
    {
        
        MechanicsObj.SetActive(false);
        ReloadSound.Play();
        this.GetComponent<Animation>().Play("M9Reload");
    }
}
