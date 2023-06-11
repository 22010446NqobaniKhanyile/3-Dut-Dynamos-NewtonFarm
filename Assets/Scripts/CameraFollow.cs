using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   public float FollowSpeed = 1.0f;
    public float YOffset = 1f;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 NewPos = new Vector3(target.position.x, target.position.y + YOffset, -10f);
        transform.position = Vector3.Slerp(transform.position, NewPos, FollowSpeed * Time.deltaTime);
        
    }
}
