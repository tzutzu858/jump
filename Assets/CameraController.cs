using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("cat2");
    }

    void Update()
    {
        Vector3 playerPos = this.player.transform.position;    //確認遊戲角色的Y座標
        transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);    //調整攝影機的Y座標
    }
}