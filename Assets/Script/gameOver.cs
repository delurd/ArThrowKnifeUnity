using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour {

	public gameOverScreen gameOverScreen;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame

	public void GameOver()
    {
		gameOverScreen.Over();
    }
}
