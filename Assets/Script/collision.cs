using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {
	Rigidbody rigidb;
	FailCount failCount;
	// Use this for initialization
	void Start () {
		rigidb = GetComponent<Rigidbody>();
		failCount = FindObjectOfType<FailCount>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Player")
		{
			failCount.failValue += 1;

			Destroy(gameObject, 0.3f);
		}
        /*else if("Player" != collision.collider.tag)
        {
			failCount.failValue += 1;
		}*/
	}
}
