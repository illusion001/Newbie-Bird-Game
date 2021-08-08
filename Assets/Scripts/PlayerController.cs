using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerView playerView;
    public GameController gameController;

    public void CollisionWithObstacle()
    {
        gameController.gameOver();
    }
    public void TriggerWithPass()
    {
        gameController.scoreUp();
    }
}
