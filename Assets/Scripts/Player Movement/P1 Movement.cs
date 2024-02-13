using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class P1Movement : MonoBehaviour
{
    public bool isGrounded;
    private Rigidbody rb => GetComponent<Rigidbody>();

    private float horizontalInput;

    private float verticalInput;

    //movement variables
    [SerializeField] public float p1moveSpeed;
    [SerializeField] private float p1jumpForce;

    private void OnJump()
    {
        if (isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, p1jumpForce, rb.velocity.z);
        }
    }

    private void OnHorizontalMovement(InputValue axis)
    {
        horizontalInput = axis.Get<float>();
    }

    private void OnVerticalMovement(InputValue axis)
    {
        verticalInput = axis.Get<float>();
    }

    private void FixedUpdate()
    {
        //Debug.Log("horizontal input: " + horizontalInput + " vertical input: " + verticalInput);
        rb.velocity = new Vector3(horizontalInput * p1moveSpeed, rb.velocity.y, verticalInput * p1moveSpeed);
    }
}
