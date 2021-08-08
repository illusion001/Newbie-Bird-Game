using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public PlayerController playerController;
    // public PlayerModel playerModel;
    private Rigidbody2D rb;
    public float jumpForce = 8f;

    void Start()
    {
        // playerModel.jumpForce = 8f;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        CheckForInput();
    }

    private void CheckForInput()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }


    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "OutBounds" || col.gameObject.tag == "Obstacle")
        {
            playerController.CollisionWithObstacle();
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Pass")
        {
            playerController.TriggerWithPass();
        }
    }


}
