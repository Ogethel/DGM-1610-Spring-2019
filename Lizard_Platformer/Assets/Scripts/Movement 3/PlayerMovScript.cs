using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovScript : MonoBehaviour
{
    //https://www.youtube.com/watch?v=QGDeafTx5ug
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
        if (isGrounded == true)
        {
            numExtraJumps = numExtraJumpsValue;
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
    }

    private void SetCollectionText()
    {
        collectionText.text = "Collections so far: " + count;
    }
}

