using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    public GameObject door;

    //执行开门动画判定
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {

            bool x = door.GetComponent<Animator>().GetBool("open");
            x = !x;
            door.GetComponent<Animator>().SetBool("open", x);

        }    
    }
}
