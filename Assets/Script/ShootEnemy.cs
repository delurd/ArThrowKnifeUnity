using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    public int distanceOfRay = 20;

    private RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.5f));

        Debug.DrawLine(transform.position, hit.point, Color.red);
        if (Physics.Raycast(ray, out hit, distanceOfRay))
        {
            if (Input.GetButtonDown("Fire1") && hit.transform.CompareTag("Enemy"))
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
