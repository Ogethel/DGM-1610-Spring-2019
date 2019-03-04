using System.Collections;
using System.Collections.Generic;
using UnityEngine;
{CreateAssetMenuAttribute}
public class MoveSingleJump : MoveBase
{
    public override void Move(CharacterController controller);
    {
        if (controller.isGrounded && Input.GetButton("Jump"))
        {
            position.y = JumpForce;
        }
        
        position.y += Gravity * Time.deltaTime;
        position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        controller.Move(position);
    }
}
