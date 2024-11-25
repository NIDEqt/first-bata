using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{

    public float moveSpeed = 5;
    public float jumpSpeed = 15;
    public float g = 10;

    public CharacterController Playercontroller;

    Vector3 move;

    //移动逻辑判定与实行
    //跳跃逻辑判定与实行
    
    void Update()
    {
        float X = 0, Z = 0;

        if (Playercontroller.isGrounded)
        {
            X = Input.GetAxis("Horizontal");
            Z = Input.GetAxis("Vertical");
            move = (transform.right * X + transform.forward * Z) * moveSpeed;
            if (Input.GetAxis("Jump") == 1)
            {
                move.y = jumpSpeed;
            }


        }

        //添加重力、角色控制器
        move.y = move.y - g * Time.deltaTime;
        Playercontroller.Move(move * Time.deltaTime);


    }
}
