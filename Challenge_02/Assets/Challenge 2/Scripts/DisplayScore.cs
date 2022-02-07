using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{

    public Text textbox;
    public Text youWin;

    public int score = 0;

    public static bool won = false;

    // public HealthSystem healthSystem;

    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();

        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;

        if (score >= 5)
        {
            won = true;
        }

        //if(score >= 5)
        //{
        //    healthSystem.gameOver = false;

        //    textbox.text = "You Win!\nPress 'R' to Restart!";
        //}


        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        //} 
    }

}
