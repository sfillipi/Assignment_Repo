using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public int score = 0;
    public Text scoreText;

    public PlayerPlatformerController playerController;
    public PlayerEnterTrigger playerFinish;

    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if(playerController == null)
        {
            playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerPlatformerController>();
        }

        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;

        //if(!playerFinish.gameOver)
        //{
        //    scoreText.text = "Score: " + score;
        //}

        if(playerFinish.gameOver)
        {
            scoreText.text = "You win!";
        }

    }
}
