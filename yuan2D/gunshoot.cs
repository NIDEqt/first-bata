using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunshoot : MonoBehaviour
{
    public GameObject gunBullet;
    private int shootTime=0;
    public int shootCd=10;
    

    //子弹发射逻辑
    //限制射击速度逻辑
    //调用音效判定
    
    void Update()
    {

        if (shootTime == 0)
        {
            if (Input.GetAxis("Fire1") == 1)
            {
                GameObject bullet = GameObject.Instantiate(gunBullet, transform.position, transform.rotation);
                shootTime = shootCd;
              
            }
        }
       else
        {
            shootTime = shootTime - 1;
        }
    }
}
