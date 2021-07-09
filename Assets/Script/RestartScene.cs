using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
	gameOver go;
	Pause pause;

	public string nameScene = "SampleScene";

	void Start()
	{
        go = FindObjectOfType<gameOver>();
		pause = FindObjectOfType<Pause>();
		Time.timeScale = 1;
	}
	public void Restart()
	{
		/* go.GameOver(false);*/
		SceneManager.LoadScene(nameScene);


        /*		Time.timeScale = 1;*/
    }
}
