using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    private GameObject target;

    public float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
        transform.LookAt(target.transform);
    }
}
