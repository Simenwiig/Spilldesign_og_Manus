using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Animator animator;

    public float moveSpeed = 6;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        PlayerMove();
        PlayerAnim();
    }

    private void PlayerMove()
    {
        //input
        float x = Input.GetAxisRaw("Horizontal") * moveSpeed;
        float y = Input.GetAxisRaw("Vertical") * moveSpeed;

        //moving
        Vector3 movePos = transform.right * x + transform.forward * y;
        Vector3 newMovePos = new Vector3(movePos.x, rb.velocity.y, movePos.z);

        rb.velocity = newMovePos;
    }

    void PlayerAnim()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.Play("Pick_Up");
        }

    }
}
