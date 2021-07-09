using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FailCount : MonoBehaviour
{
    public int failValue = 2;
    public Text fail;

    Pause pause;
    gameOver go;
    gameOverScreen gos;
    RestartScene RS;

    // Start is called before the first frame update
    void Start()
    {
        RS = FindObjectOfType<RestartScene>();
        gos = FindObjectOfType<gameOverScreen>();
        go = FindObjectOfType<gameOver>();
        pause = FindObjectOfType<Pause>();


        
    }

    // Update is called once per frame
    void Update()
    {
        if(failValue > 3)
        {
            failValue = 3;
        }

        fail.text = "Lives : " + failValue.ToString();

        if (failValue == 0)
        {
            go.GameOver();
            /* RS.Restart();*/
            Time.timeScale = 0;
            /*pause.pauseGame();*/
        }

    }
}
