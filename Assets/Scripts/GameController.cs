using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameController : MonoBehaviour
{
    public PlayerController playerController;
    public GameView gameView;
    public int score;
    void Start()
    {
        Time.timeScale = 1;
    }
    public void gameOver()
    {
        Time.timeScale = 0;
        gameView.showGameOverScreen();
    }

    public void scoreUp()
    {
        score++;
        gameView.showNewScore(score);
    }

    public void startNewGame(){
        gameView.startNewGame();
    }

}
