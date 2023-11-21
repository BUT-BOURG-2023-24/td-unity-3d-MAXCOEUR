using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JumpBehaviour : MonoBehaviour
{
    public float jumpForce = 100f;
    public InputActionReference jumpAction;
    public Rigidbody rb;
    public GourndCheck GourndCheck;

    private void OnEnable()
    {
        jumpAction.action.performed += Action_performed;
    }
    private void OnDisable()
    {
        jumpAction.action.performed -= Action_performed;
    }

    private void Action_performed(InputAction.CallbackContext obj)
    {
        Jump();
    }

    void Jump()
    {
        if (GourndCheck.getIsGround())
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
    
}
