using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///
///</summary>
public class MovePlayer : MonoBehaviour
{
    //���������ƶ�
    private float Horizontal;
    //�������¼��ƶ�
    private float Vertical;
    //���x���ƶ��������Ļ���ԣ�
    private float MouseX;
    //���y���ƶ��������Ļ���ԣ�   ע����Ļû��z������û�����z���ƶ���input
    private float MouseY;
    //�ƶ��ٶ�
    public float moveSpeed = 10;
    //��ת�ٶ�
    public float rotateSpeed = 50;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //���̵�ad���͡����������ƶ�    ��-1    �ң�1
        Horizontal = Input.GetAxis("Horizontal");
        //���̵�ws���͡����������ƶ�
        Vertical = Input.GetAxis("Vertical");
        //����ƶ���������ת
        MouseX = Input.GetAxis("Mouse X");
        MouseY = Input.GetAxis("Mouse Y");
        //�ƶ�  ����ad���������ά����ϵ��x�ᣬws�����z��
        this.transform.Translate(Horizontal * Time.deltaTime * moveSpeed, 0, Vertical * Time.deltaTime * moveSpeed);
        //��ת �����������������λ�������y����ת�������������������x����ת(ע�����������һ����ֵ������ת����ʱ����ת����x����תҪ��ת������)
        //y��Ҫ������������
        this.transform.Rotate(0 * Time.deltaTime, MouseX * rotateSpeed * Time.deltaTime, 0, Space.World);
        //x��Ҫ��������
        this.transform.Rotate(-MouseY * rotateSpeed * Time.deltaTime, 0, 0);

        print("Horizontal" + Horizontal);
        print("Vertical" + Vertical);
    }
}
