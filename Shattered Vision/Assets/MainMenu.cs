using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void PlayTutorial()
	{
		SceneManager.LoadSceneAsync(1);
	}

    public void PlayLevelOne()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void QuitGame()
	{
		Application.Quit();
	}

	public void EndGame()
	{
		SceneManager.LoadScene(0);
	}

}
