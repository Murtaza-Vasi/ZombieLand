using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class GamePause : MonoBehaviour
{
    public bool Paused = false;
    public GameObject ThePlayer;
    public float EnemySpeed = ZombieFollow.EnemySpeed;
    public GameObject PauseMenu;

    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            if(Paused == false)
            {                                               // Pauses the game
                PauseMenu.SetActive(true);
                Time.timeScale = 0;
                Paused = true;
                EnemySpeed = 0;
                ThePlayer.GetComponent<FirstPersonController>().enabled = false;
                Cursor.visible = true;
            }
            else
            {                                               // Resumes the game
                PauseMenu.SetActive(false);
                ThePlayer.GetComponent<FirstPersonController>().enabled = true;
                Paused = false;
                EnemySpeed = 0.01f;
                Time.timeScale = 1;
            }

        }
    }
}
