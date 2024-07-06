using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    float horizontal, vertical;
    Vector3 moveVector, vel;
    bool jumpp, isGrounded;

    float Jump = 12f;
    float gravity = -9.81f;

    float mspd = 15f;


    CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        jumpp = Input.GetButtonDown("Jump");
        isGrounded = controller.isGrounded;


        moveVector = new Vector3(horizontal, 0f, vertical);
        controller.Move(moveVector.normalized * mspd * Time.deltaTime);

        if (jumpp && isGrounded)
        {
            print("jumped at");
            print(transform.position.y);
            vel.y += Jump;
        }

        vel.y += gravity * Time.deltaTime;
        controller.Move(vel * Time.deltaTime);
    }

    //private void FixedUpdate()
    //{
        //  rb.AddForce(moveVector.normalized * mspd * Time.deltaTime, ForceMode.Force);
    //}
}

