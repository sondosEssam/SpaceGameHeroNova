using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll2D : MonoBehaviour
{
    private float horizontal;
    private float speed =8f;
    private float JumpPower=8f;
    private bool isFacingRight = true;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;  

        void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
         if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpPower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }
    private void FixedUpdate(){
        rb.velocity = new Vector2( horizontal* speed, rb.velocity.y);
    }
    private bool IsGrounded (){
          return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
   /* private void flip()
    if*/
}  
