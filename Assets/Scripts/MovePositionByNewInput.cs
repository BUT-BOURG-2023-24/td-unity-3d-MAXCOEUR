using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePositionByNewInput : MonoBehaviour
{
    public float speed = 10.0f;
    public InputActionReference moveInputRef;

    public Animator animator;
    public GourndCheck GourndCheck;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputMovement = moveInputRef.action.ReadValue<Vector2>();

        transform.position += new Vector3(inputMovement.x*speed*Time.deltaTime,0,inputMovement.y*speed*Time.deltaTime);

        if (animator != null)
        {
            animator.SetFloat("speed", inputMovement.magnitude);
            animator.SetBool("isGrounded", GourndCheck.getIsGround());
        }
    }
}
