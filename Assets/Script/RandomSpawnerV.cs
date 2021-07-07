using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnerV : MonoBehaviour
{
    public GameObject[] enemies;

    FailCount failCount;

    public int maxtimer = 8;
    public int mintimer = 4;
    private float timer;
    private float timetospawn;
    public float xmin = -1.5f, xmax = 1.5f;
    public float ymin = -2f, ymax = 2f;
    public float zmin = 8f, zmax = 10f;

    private float objX, objY, objZ;

    // Start is called before the first frame update
    void Start()
    {
        timetospawn = Random.Range(mintimer, maxtimer);
        failCount = FindObjectOfType<FailCount>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timetospawn)
        {
            timer = 0;
            timetospawn = Random.Range(mintimer, maxtimer);
            Debug.Log(timetospawn);
            RandomPosition();
            Spawn(Random.Range(0, enemies.Length));
        }
    }
    void RandomPosition()
    {
        objX = Random.Range(xmin, xmax);
        objY = Random.Range(ymin, ymax);
        objZ = Random.Range(zmin, zmax);

    }
    void Spawn(int index)
    {
        Instantiate(enemies[index], new Vector3(objX, objY, objZ), transform.rotation);
        failCount.failValue -= 1;
    }
}
