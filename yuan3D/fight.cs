using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fight : MonoBehaviour
{

    //敌人伤害判定
    //角色扣血逻辑
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            other.gameObject.GetComponent<HP>().reduce(100);
        }
    }
}
