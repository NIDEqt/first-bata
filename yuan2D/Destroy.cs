using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
   
   //计时自毁
    void Start()
    {
        Destroy(gameObject,0.75f);
    }

   
}
