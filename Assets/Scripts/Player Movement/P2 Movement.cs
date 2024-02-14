using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class P2Movement : MonoBehaviour
{
    public bool isGrounded;
    private Rigidbody rb => GetComponent<Rigidbody>();

    private float horizontalInput;

    private float verticalInput;

    //movement variables
    [SerializeField] public float p2moveSpeed;
    [SerializeField] public float p2jumpForce;

    private void OnJump2()
    {
        if (isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, p2jumpForce, rb.velocity.z);
        }
    }

    private void OnHorizontalMovement2(InputValue axis)
    {
        horizontalInput = axis.Get<float>();
    }

    private void OnVerticalMovement2(InputValue axis)
    {
        verticalInput = axis.Get<float>();
    }

    private void FixedUpdate()
    {
        //Debug.Log("horizontal input: " + horizontalInput + " vertical input: " + verticalInput);
        rb.velocity = new Vector3(horizontalInput * p2moveSpeed, rb.velocity.y, verticalInput * p2moveSpeed);
    }
}
