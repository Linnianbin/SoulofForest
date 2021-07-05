using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform playerTrans;
    public GameObject player;
    private Vector3 offset;
    private void Awake()
    {
        playerTrans = player.transform;
        offset = transform.position - playerTrans.position;
        offset = new Vector3(0, offset.y, offset.z);
    }

    void Update()
    {
        //transform.position = Vector3.Lerp(transform.position, playerTrans.position + offset, Time.deltaTime*10);//用这个可能会发生抖动
        transform.position = playerTrans.position + offset;
    }
}
