using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemyOnLeft : MonoBehaviour
{
    public GameObject smallEnemy, middleEnemy, bigEnemy;
    
    void Start()
    {
        CreateSmallEnemy(-6.5f, -2.95f, 2.95f, 5f);
        CreateMiddleEnemy(-6.5f, -2.8f, 2.8f, 3.5f);
        CreateBigEnemy(-6.5f, -2.7f, 2.7f, 2f);
    }

    public void CreateSmallEnemy(float posX, float minY, float maxY, float speed)
    {
        GameObject small = Instantiate(smallEnemy, new Vector2(posX, Random.Range(minY, maxY)), Quaternion.identity) as GameObject;
        small.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, transform.position.y);
    }

    public void CreateMiddleEnemy(float posX, float minY, float maxY, float speed)
    {
        GameObject middle = Instantiate(middleEnemy, new Vector2(posX, Random.Range(minY, maxY)), Quaternion.identity) as GameObject;
        middle.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, transform.position.y);
    }

    public void CreateBigEnemy(float posX, float minY, float maxY, float speed)
    {
        GameObject big = Instantiate(bigEnemy, new Vector2(posX, Random.Range(minY, maxY)), Quaternion.identity) as GameObject;
        big.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, transform.position.y);
    }
}
