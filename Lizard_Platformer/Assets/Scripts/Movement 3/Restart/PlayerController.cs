using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rgb;

    private void start()
    {
        rgb.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    private void Update()
    {
        PlayerMovement(rgb);
    }

    private void PlayerMovement(Rigidbody rigidBody)
    {
        if (Input.GetKey("a"))
        {
            rigidBody.velocity = new Vector2(-10, rigidBody.velocity.y);
        }
        
        if (Input.GetKey("d"))
        {
            rigidBody.velocity = new Vector2(10, rigidBody.velocity.y);
        }

        if (Input.GetKeyDown("space"))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, 10);
        }
    }
}
