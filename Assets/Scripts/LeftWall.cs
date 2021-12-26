using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWall : MonoBehaviour
{   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SmallEnemy"))
        {
            collision.gameObject.transform.position = new Vector2(6.5f, Random.Range(-2.95f, 2.95f));
        }
        else if (collision.gameObject.CompareTag("MiddleEnemy"))
        {
            collision.gameObject.transform.position = new Vector2(6.5f, Random.Range(-2.8f, 2.8f));
        }
        else if (collision.gameObject.CompareTag("BigEnemy"))
        {
            collision.gameObject.transform.position = new Vector2(6.5f, Random.Range(-2.7f, 2.7f));
        }
    }
}
