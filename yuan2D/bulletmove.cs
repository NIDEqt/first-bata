using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour
{
    public float force;
    public float time;
    public Rigidbody2D rig;
    public Transform bulletTp;
   Transform faceCheck;
    Transform tpCheck;
    //子弹自毁逻辑
    //碰撞箱判定
    void Start()
    {
        faceCheck = GameObject.Find("TOAD").GetComponent<Transform>();
        tpCheck = GameObject.Find("gun").GetComponent<Transform>();
    }
    private void Update()
    {
        Fire();
    }

    void Fire()
    {
        Destroy(gameObject, time);

        if (!(tpCheck.position.x != bulletTp.position.x))
        {
            if (faceCheck.localScale.x > 0)
            {
                rig.AddForce(this.transform.right * force);
            }
            else
            {
                rig.AddForce(-this.transform.right * force);
            }
        }
        


    }

}
