using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonApplication : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Credits()
    {
        SceneManager.LoadScene(2);
    }
	
	public void Exit()
	{
		Application.Quit();
	}
	
	public void Resume_Game()
	{
		
	}

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
