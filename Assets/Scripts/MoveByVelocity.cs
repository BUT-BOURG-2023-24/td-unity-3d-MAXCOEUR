using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveByVelocity : MonoBehaviour
{
    public float speed = 10.0f;
    public InputActionReference moveInputRef;
    public Rigidbody rb;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputMovement = moveInputRef.action.ReadValue<Vector2>();

        // Add velocity to the Rigidbody based on the calculated movement
        rb.velocity = new Vector3(inputMovement.x* speed, rb.velocity.y, inputMovement.y * speed);
    }
}
