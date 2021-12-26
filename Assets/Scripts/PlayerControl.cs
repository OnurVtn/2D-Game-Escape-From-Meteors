using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D playerRigidbody;
    public float speed;
    private bool secondClick = false;

    void Update()
    {
        if (secondClick == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                playerRigidbody.velocity = new Vector2(transform.position.x, speed);
                secondClick = true;
            }
        }

        else if (secondClick == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                playerRigidbody.velocity = new Vector2(transform.position.x, -speed);
                secondClick = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("SmallEnemy") || collision.gameObject.CompareTag("MiddleEnemy") ||
           collision.gameObject.CompareTag("BigEnemy"))
        {
            Time.timeScale = 0;
        }
    }
}
