using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooted : MonoBehaviour
{

    public GameObject shell;

    //命中效果赋予与判定
    //弹壳掉落
    //命中时摧毁物体
    private void OnCollisionEnter(Collision collision)
    {
        
            if (collision.gameObject.tag == "enemy")
            {
            collision.gameObject.GetComponent<HP>().reduce(10);
            }
            GameObject sui = GameObject.Instantiate(shell,transform.position,transform.rotation);
            Destroy(gameObject);
        
    }
}
