using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gameOverScreen : MonoBehaviour {
	public Text point;
	pointCount PC;

	// Use this for initialization
	void Start()
	{
		PC = FindObjectOfType<pointCount>();

	}

	public void Over()
	{
			gameObject.SetActive(true);
		point.text = "Score : " + PC.pointValue.ToString();

	}

}
