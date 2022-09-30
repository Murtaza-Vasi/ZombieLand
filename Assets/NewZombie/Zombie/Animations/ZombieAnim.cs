using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAnim : MonoBehaviour
{
    public GameObject theZombie;
    public void ChangeAnim()
    {
        theZombie.GetComponent<Animation>().Play("attack");
    }
}
