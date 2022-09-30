using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunDamage : MonoBehaviour
{
    static public int Damage;
    public int ShotDamage;
    public float TargetDistance;
    public float AllowedDistance = 5;


    // Update is called once per frame
    void Update()
    {
        if (Ammo.LoadedAmmo >= 1)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                RaycastHit Shot;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
                {
					TargetDistance = Shot.distance;
                    if (TargetDistance < AllowedDistance)
                    {
						Debug.Log(Shot.collider.tag);
						if(Shot.collider.tag == "Zombie")
						{
							float tmp = 1-(TargetDistance / AllowedDistance);
							tmp *= Damage;
							ShotDamage =(int)tmp;
							EnemyScript e = Shot.transform.GetComponent<EnemyScript>();
							e.DeductPoints(ShotDamage);
                        }
						
						if(Shot.collider.tag == "Capsule")
						{
							float tmp = 1-(TargetDistance / AllowedDistance);
							tmp *= Damage;
							ShotDamage =(int)tmp;
							CapsuleHealth c = Shot.transform.GetComponent<CapsuleHealth>();
							Debug.Log("Hello World");
							c.DeductPointsCapsule(ShotDamage);
						}
                    }
                }
            }
        }
    }

    public static void SetGunDamage(int GD)
    {
        Damage = GD;
    }
}
