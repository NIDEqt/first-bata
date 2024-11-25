using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int Hppoint=100;

    //生命减少方法
    public void reduce(int x)
    {
        Hppoint = Hppoint - x;
    }

    //销毁判定
    void Update()
    {
        
        if(Hppoint<=0)
        {
            Destroy(gameObject);
        }

        
    }
}
