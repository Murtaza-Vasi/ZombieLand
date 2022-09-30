using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShot : MonoBehaviour
{
    public AudioSource GunShotSound;
    public Animation GunShotAnim;

    void Update()
    {
        if (Ammo.LoadedAmmo >= 1)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                GunShotAnim.Play();
                GunShotSound.Play();
                Ammo.LoadedAmmo -= 1;
            }
        }
    }
}
