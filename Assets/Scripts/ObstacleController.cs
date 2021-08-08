using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public GameController gameController;
    public GameObject obstacleSpawner;
    public GameObject obstacle;
    public float maxTime = 4;
    private float timer = 0;
    public float height= 2;

    void Update()
    {
        if (timer > maxTime)
        {
            CreateNewObstacle();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    public void CreateNewObstacle()
    {
        GameObject newObstacle = Instantiate(obstacle);
        newObstacle.transform.position = obstacleSpawner.transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newObstacle, 10);
    }
}
