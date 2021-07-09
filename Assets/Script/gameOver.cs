using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour {

	public gameOverScreen GameOverScreen;
	// Use this for initialization

	// Update is called once per frame

	public void GameOver()
    {
		GameOverScreen.Over();
    }
}
