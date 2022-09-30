using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylindreicalWepondisplayer : MonoBehaviour
{
    public GameObject ThePlayer;
    void Update()
    {
        transform.rotation = Quaternion.Euler(0f,-ThePlayer.transform.rotation.eulerAngles.y - 90 +11 ,0f);
    }
}
