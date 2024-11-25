using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [Header("速度数值")]
    public float moveSpeed=10;
    public float jumpSpeed=5;
    [Header("跳跃次数")]
    public float jumpCount ;
    [Header("判定")]
    public bool isGround;
    public bool isJump;
    public bool pressedJump;

    [Header("组件")]
    public Transform foot;
    public Rigidbody2D playerRig;
    public Collider2D playerCol;
    public LayerMask Ground;

   
   
    void Update()
    {

        UpdateChenk();

    }

    private void FixedUpdate()
    {
        Action();
        FixedupdateCheck();
        Jump();
       
    }
    void Action()
    {
        float xy = 0;
        float face;



        xy = Input.GetAxis("Horizontal");
        face = Input.GetAxisRaw("Horizontal");
        playerRig.velocity = new Vector2(moveSpeed * xy, playerRig.velocity.y);
        if(face!=0)
        {
            transform.localScale = new Vector3(face,transform.localScale.y,transform.localScale.z);

        }
        
        

        if (xy != 0)
        {
            this.gameObject.GetComponent<Animator>().SetBool("run", true);
           
        }
        
        else
        {
            this.gameObject.GetComponent<Animator>().SetBool("run", false);
            
        }

    }

    void Jump()
    {
       
        if(isGround)
        {
            jumpCount = 1;
            isJump = false;
        }
       
        if (pressedJump && jumpCount>0) 
        {
            pressedJump = false;
            playerRig.velocity = new Vector2(playerRig.velocity.x, jumpSpeed);
            jumpCount--;
           
        }
        else if(pressedJump && jumpCount>0 &&!isGround)
        {
            pressedJump = false;
            playerRig.velocity = new Vector2(playerRig.velocity.x, jumpSpeed);
            jumpCount--;
        }
        if(jumpCount<1 && !isGround)
        {
            pressedJump = false;
        }

    }

    void FixedupdateCheck()
    {
        isGround = Physics2D.OverlapCircle(foot.position, 0.1f, Ground);
    }

    void UpdateChenk()
    {
        if(Input.GetButtonDown("Jump"))
        {
            pressedJump = true;
        }
       
    }
}
