using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeScript : MonoBehaviour
{

	Vector2 startPos, endPos, direction; // touch start position, touch end position, swipe direction
	float touchTimeStart, touchTimeFinish, timeInterval; // to calculate swipe time to sontrol throw force in Z direction

	[SerializeField]
	float throwForceInXandY = 1f; // to control throw force in X and Y directions

	[SerializeField]
	float throwForceInZ = 50f; // to control throw force in Z direction

	Rigidbody rb;



	pointCount Pointcount;
	FailCount failCount;
	SpawnBall spawnBall;

	RestartScene restartScene;



	void Start()
	{
		//Call rotate script
		Pointcount = FindObjectOfType<pointCount>();
		failCount = FindObjectOfType<FailCount>();
		spawnBall = FindObjectOfType<SpawnBall>();



		restartScene = FindObjectOfType<RestartScene>();


		rb = GetComponent<Rigidbody>();
		transform.rotation = Quaternion.AngleAxis(180, Vector3.up);

	}

	// Update is called once per frame
	void Update()
	{


		// if you touch the screen
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
		{

			// getting touch position and marking time when you touch the screen
			touchTimeStart = Time.time;
			startPos = Input.GetTouch(0).position;


		}

		// if you release your finger
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
		{



			// marking time when you release it
			touchTimeFinish = Time.time;

			// calculate swipe time interval 
			timeInterval = touchTimeFinish - touchTimeStart;

			// getting release finger position
			endPos = Input.GetTouch(0).position;

			// calculating swipe direction in 2D space
			direction = startPos - endPos;



			// add force to balls rigidbody in 3D space depending on swipe time, direction and throw forces
			rb.isKinematic = false;
			rb.AddForce(-direction.x * throwForceInXandY, -direction.y * throwForceInXandY, throwForceInZ / timeInterval);
			//rb.AddTorque(Vector3.down * 2);

			//transform.Rotate(Vector3.right * 2);

			//StartCoroutine(tunggudulu());
		}


	}

	IEnumerator tunggudulu()
	{
		yield return new WaitForSeconds(0.3f);
		spawnBall.Spawn();
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Enemy")
		{
			rb.constraints = RigidbodyConstraints.FreezeAll;

			Pointcount.pointValue += 1;

		}
		else
		{
            if ("Player" != collision.collider.tag)
            {
                // Destroy ball in 2 seconds
                Destroy(gameObject, 1f);

                /*failCount.failValue += 1;*/
            }

        }
	}

}


