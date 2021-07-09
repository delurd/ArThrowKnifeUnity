using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pointCount : MonoBehaviour
{
    public int pointValue ;
    public Text point;

    RandomSpawnerV RSV;


    // Start is called before the first frame update
    void Start()
    {
        pointValue = 0;

    }

    // Update is called once per frame
    void Update()
    {
        point.text = "Score : " + pointValue.ToString();


        if(pointValue % 10 == 0)
        {

        }
    }


}
