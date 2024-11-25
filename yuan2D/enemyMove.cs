using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public Transform enemyTarget;
    public float enemyMoveSpeed;
    public float followDistance;
    

    void Start()
    {
        enemyTarget = GameObject.FindGameObjectWithTag("Player").transform;
    }

   
    void Update()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        
        if (Mathf.Abs(transform.position.x - enemyTarget.position.x ) < followDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, enemyTarget.position, enemyMoveSpeed * Time.deltaTime);
           

            if (transform.position.x-enemyTarget.position.x < 0)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);   
                
            }

            if (transform.position.x - enemyTarget.position.x > 0)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);

            }
            

        }

        
    }
}
