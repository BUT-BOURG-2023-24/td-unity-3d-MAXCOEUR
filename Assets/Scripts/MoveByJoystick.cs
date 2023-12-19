using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveByJoystick : MonoBehaviour
{
    // Start is called before the first frame update
    public Joystick joystick;
    public float speed = 10.0f;
    public Rigidbody rb;
    public Animator animator;
    public GourndCheck GourndCheck;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputMovement = joystick.Direction;
        rb.velocity = new Vector3(inputMovement.x * speed, rb.velocity.y, inputMovement.y * speed);
        if (animator!=null)
        {
            animator.SetFloat("speed", inputMovement.magnitude);
            animator.SetBool("isGrounded", GourndCheck.getIsGround());
        }
        
    }
}
