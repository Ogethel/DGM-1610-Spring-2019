﻿using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovScript : MonoBehaviour
{
    //https://www.youtube.com/watch?v=QGDeafTx5ug
    
    public Animator animator;
    
    public float speed;
    public float jumpForce;
    private float moveInput;
    private Rigidbody rb;
    private bool charFaceRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int numExtraJumps;
    public int numExtraJumpsValue;

    public Text collectionText;
    private int count = 0;

    public GameObject invincible;
    public float invincTime = 7.0f;
    private bool isInvinc = false;

    void Start()
    {
        numExtraJumps = numExtraJumpsValue;
        rb = GetComponent<Rigidbody>();
        SetCollectionText();
    }
    void FixedUpdate()
    {
        //https://answers.unity.com/questions/527307/sticky-and-blocking-colliders-that-stop-my-charact.html
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.right, out hit, 0.1f)
            || Physics.Raycast(transform.position, Vector3.left, out hit, 0.1f)) {
            Debug.Log("Hit " + hit.transform.gameObject.name);
            if (hit.transform.tag == "Stoppable"){
                rb.velocity = new Vector2(0, rb.velocity.y);
            }
        }
        
        animator.SetFloat("Speed", Mathf.Abs(moveInput));

        isGrounded = Physics.CheckSphere(groundCheck.position, checkRadius, whatIsGround);

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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("IsJumping", true);
        }
        if (isGrounded == true)
        {
            numExtraJumps = numExtraJumpsValue;
            animator.SetBool("IsJumping", false);
        }

        if (Input.GetKeyDown(KeyCode.W) && numExtraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            numExtraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.W) && numExtraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }


    void FlipChar()
    {
        charFaceRight = !charFaceRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
     
    }

    public void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("PickUps")) return;
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCollectionText();
            
        if (invincible)
        {
            enterInvincible();
        }
    }

    private void SetCollectionText()
    {
        collectionText.text = "Collections so far: " + count;
    }

    public void enterInvincible()
    {
        isInvinc = true;
        if (invincTime >= 0.01)
        {
            GetComponent("UpdateBar").SendMessage("stopBadyDamage");
        }
        else
        {
            isInvinc = false;
        }
        
    }
}

