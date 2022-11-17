using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    CharacterController controller;

    Vector3 forward;
    Vector3 vertical;
    Vector3 strafe;
    
    float forwardSpeed = 60f;
    float strafeSpeed = 60f;


    float gravity;
    float jumpSpeed;
    float maxJumpHeight = 10f;
    float timeToMaxHeight = 0.5f;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        gravity = (-2 * maxJumpHeight) / (timeToMaxHeight * timeToMaxHeight);
        jumpSpeed = (2 * maxJumpHeight) / timeToMaxHeight;


    }

   
    void Update()
    {

        float forwardInput = Input.GetAxisRaw("Vertical");
        float strafeInput = Input.GetAxisRaw("Horizontal");

        forward = forwardInput * forwardSpeed * transform.forward;
        strafe = strafeInput * strafeSpeed * transform.right;

        vertical += gravity * Time.deltaTime * Vector3.up;

        if(controller.isGrounded){
            vertical = Vector3.down;
        }

        if(Input.GetKeyDown(KeyCode.Space) && controller.isGrounded){
            vertical = jumpSpeed * Vector3.up;
        }

        Vector3 finalVelocidade = forward + strafe + vertical;

        controller.Move(finalVelocidade * Time.deltaTime);
    }



}
