using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    public Vector3 maxPosition;
    public Vector3 minPosition;

   // GameObject player;

    void Start()
    {
      //  this.player = GameObject.Find("cat2");
    }

    void Update()
    {
       // Vector3 playerPos = this.player.transform.position;    //確認遊戲角色的Y座標
       // transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);    //調整攝影機的Y座標

        if (transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x,
                                                 target.position.y,
                                                 transform.position.z);

            targetPosition.x = Mathf.Clamp(targetPosition.x,
                                           minPosition.x,
                                           maxPosition.x);

            targetPosition.y = Mathf.Clamp(targetPosition.y,
                                           minPosition.y,
                                           maxPosition.y);


            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }

    }



}
