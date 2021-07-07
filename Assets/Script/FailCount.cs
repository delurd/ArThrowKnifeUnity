using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FailCount : MonoBehaviour
{
    public int failValue = 2;
    public Text fail;

    gameOver go;
    gameOverScreen over;
    RestartScene RS;

    // Start is called before the first frame update
    void Start()
    {
        RS = FindObjectOfType<RestartScene>();
        over = FindObjectOfType<gameOverScreen>();
        go = FindObjectOfType<gameOver>();


        
    }

    // Update is called once per frame
    void Update()
    {
        fail.text = "Lives : " + failValue.ToString();

        if (failValue == 0)
        {
          /*  go.GameOver();*/
            RS.Restart();
        }

    }
}
