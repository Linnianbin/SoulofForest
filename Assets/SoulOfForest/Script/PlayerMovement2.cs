using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float turnSpeed = 20f;

    Animator m_Animator;
    Rigidbody m_Rigidbody;
    AudioSource m_AudioSource;
    Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;

    void Start()
    {
        m_Animator = GetComponent<Animator>();
        m_Rigidbody = GetComponent<Rigidbody>();
        // m_AudioSource = GetComponent<AudioSource>();
        //this.transform.rotation
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            m_Animator.SetBool("IsJumping", true);
        }
        else
            m_Animator.SetBool("IsJumping", false);
    }
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal2");
        float vertical = Input.GetAxis("Vertical2");
        
        float rotation = Input.GetAxis("Rotation2");


        m_Movement.Set(horizontal, 0f, vertical);
        m_Movement.Normalize();

        bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
        bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);
        bool isWalking = hasHorizontalInput || hasVerticalInput;
        m_Animator.SetBool("IsWalking", isWalking);


        transform.Translate(horizontal / 50, 0, vertical / 50);//Translate可以控制物体移动
        transform.Rotate(0, rotation, 0);//Rotate可以控制物体转向


        /*    if (isWalking)
            {
                if (!m_AudioSource.isPlaying)
                {
                    m_AudioSource.Play();
                }
            }
            else
            {
                m_AudioSource.Stop();
            }*/

        //  Vector3 desiredForward = Vector3.RotateTowards(transform.forward, m_Movement, turnSpeed * Time.deltaTime, 0f);
        //   m_Rotation = Quaternion.LookRotation(desiredForward);
    }

    /*   void OnAnimatorMove()
       {

           m_Rigidbody.MovePosition(m_Rigidbody.position + m_Movement/100 );
           m_Rigidbody.MoveRotation(m_Rotation);
           print(m_Animator.deltaPosition.magnitude);
       }*/
}
