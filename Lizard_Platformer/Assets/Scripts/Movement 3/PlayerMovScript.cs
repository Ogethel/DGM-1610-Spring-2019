using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovScript : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;
    private Rigidbody rb;
    private bool charFaceRight = true;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (charFaceRight == false && moveInput > 0)
        {
            FlipChar();
        }
        else if (charFaceRight == true && moveInput < 0)
        {
            FlipChar();
        }
    }

    void FlipChar()
    {
        charFaceRight = !charFaceRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
        
    }


}
