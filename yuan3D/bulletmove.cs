using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour
{
    public float force;
    public float time;
    public Rigidbody rig;

    //子弹自毁逻辑
    //碰撞箱判定
    void Start()
    {
        Destroy(gameObject, time);
        rig.AddForce(this.transform.forward * force);
    }

    
   
}
