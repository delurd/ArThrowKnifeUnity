﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
	public string nameScene = "SampleScene";
	public void Restart()
	{
		SceneManager.LoadScene(nameScene);
	}
}
