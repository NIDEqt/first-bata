using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameralook : MonoBehaviour
{
    public float mouseSpeed=400;

    public Transform player;

    private float xmove;
    //限定视角转动最大角度
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    //视角转动逻辑判定
    void Update()
    {

        float x, y;
        x = Input.GetAxis("Mouse X")*mouseSpeed*Time.deltaTime;
        y = Input.GetAxis("Mouse Y")*mouseSpeed*Time.deltaTime;
        xmove = xmove - y;
        xmove = Mathf.Clamp(xmove, -90, 90);

        this.transform.localRotation = Quaternion.Euler(xmove, 0, 0);

        player.Rotate(Vector3.up * x);
    }
}
