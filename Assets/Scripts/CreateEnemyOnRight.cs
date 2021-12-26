using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemyOnRight : MonoBehaviour
{
    CreateEnemyOnLeft CreateEnemyOnLeft;
    
    void Start()
    {
        CreateEnemyOnLeft = this.gameObject.GetComponent<CreateEnemyOnLeft>();
        CreateEnemyOnLeft.CreateSmallEnemy(6.5f, -2.95f, 2.95f, -5f);
        CreateEnemyOnLeft.CreateMiddleEnemy(6.5f, -2.8f, 2.8f, -3.5f);
        CreateEnemyOnLeft.CreateBigEnemy(6.5f, -2.7f, 2.7f, -2f);
    }
}
