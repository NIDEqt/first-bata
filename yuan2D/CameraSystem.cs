using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    public Transform playerTaget;
    public float moveTime;

    private void LateUpdate()
    {
       if(playerTaget != null)
        {
            if(playerTaget.position!=transform.position)
            {
                transform.position = Vector3.Lerp(transform.position, playerTaget.position, moveTime * Time.deltaTime);
            }
        }
    }
}
