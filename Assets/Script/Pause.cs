using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour {

	[SerializeField] 
	GameObject pauseMenu;

	// Use this for initialization
	public void pauseGame()
    {
		pauseMenu.SetActive(false);
		Time.timeScale = 0;
    }
	public void resume()
    {
		pauseMenu.SetActive(false);
		Time.timeScale = 1;
/*		SceneManager.LoadScene("throwKnife");*/
	}

}
