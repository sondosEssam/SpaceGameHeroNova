using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementspeed = 1f;
    
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    // Update is called once per frame
    
    
    void Update()
    {   movement.x =Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("speed",movement.magnitude);
        animator.SetFloat("Horizontal", movement.x);
    }
    void FixedUpdate(){
    rb.MovePosition(rb.position + movement * movementspeed* Time.fixedDeltaTime);
    
    }
}