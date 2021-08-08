using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleView : MonoBehaviour
{
    public float speed = 2.5f;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
