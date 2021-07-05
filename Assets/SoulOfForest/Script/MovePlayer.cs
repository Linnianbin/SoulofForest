using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///
///</summary>
public class MovePlayer : MonoBehaviour
{
    //键盘左右移动
    private float Horizontal;
    //键盘上下键移动
    private float Vertical;
    //鼠标x轴移动（相对屏幕而言）
    private float MouseX;
    //鼠标y轴移动（相对屏幕而言）   注：屏幕没有z轴所以没有鼠标z轴移动的input
    private float MouseY;
    //移动速度
    public float moveSpeed = 10;
    //旋转速度
    public float rotateSpeed = 50;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //键盘的ad键和←→键左右移动    左：-1    右：1
        Horizontal = Input.GetAxis("Horizontal");
        //键盘的ws键和↑↓键上下移动
        Vertical = Input.GetAxis("Vertical");
        //鼠标移动来控制旋转
        MouseX = Input.GetAxis("Mouse X");
        MouseY = Input.GetAxis("Mouse Y");
        //移动  键盘ad键相对于三维坐标系的x轴，ws相对于z轴
        this.transform.Translate(Horizontal * Time.deltaTime * moveSpeed, 0, Vertical * Time.deltaTime * moveSpeed);
        //旋转 鼠标的左右移相对于三位坐标的沿y轴旋转，鼠标的上下相对于沿着x轴旋转(注意鼠标向上是一个正值但是旋转是逆时针旋转所以x轴旋转要旋转负方向)
        //y轴要沿着世界坐标
        this.transform.Rotate(0 * Time.deltaTime, MouseX * rotateSpeed * Time.deltaTime, 0, Space.World);
        //x轴要沿着自身
        this.transform.Rotate(-MouseY * rotateSpeed * Time.deltaTime, 0, 0);

        print("Horizontal" + Horizontal);
        print("Vertical" + Vertical);
    }
}
