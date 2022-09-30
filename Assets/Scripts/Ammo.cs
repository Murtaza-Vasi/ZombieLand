using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour
{
    public static int CurrentAmmo;
    public int InternalAmmo;                                          // Magazine capacity of gun 
    public GameObject AmmoDisplay;

    public static int LoadedAmmo;                              
    public int InternalLoaded;                                       // Ammo loaded in the gun
    public GameObject LoadedDisplay;

    public static int MaxInternalAmmo;
    public static int MaxAmmo;

    void LateUpdate()
    {
        InternalAmmo = CurrentAmmo;
        InternalLoaded = LoadedAmmo;

        AmmoDisplay.GetComponent<Text>().text = "" + InternalAmmo;
        LoadedDisplay.GetComponent<Text>().text = "" + InternalLoaded;
    }

    public static void MaxAssignAmmo(int MaxIA,int MaxA)
    {
        MaxInternalAmmo = MaxIA;                                //Setting the clip capacity and the magazine capacity and maximum ammo that can be carried
        MaxAmmo = MaxA;
    }
}
