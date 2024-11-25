using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{

    GameObject target;
    public float speed;
    public float look = 100;

     //敌人移动判定
     //敌人视野限制
     //敌人移动与转向逻辑
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        Vector3 vec = target.transform.position-this.transform.position  ;
        float length = vec.sqrMagnitude;
        vec.y = 0;
        if(length<look)
        {
            transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(vec), 0.3f);
            transform.position = transform.position + this.transform.forward * speed * Time.deltaTime;
        }
    }
}
