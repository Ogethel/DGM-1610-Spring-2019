using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveCharacter : MonoBehaviour
{
    public MoveBase CharacterMover;
    
    public UnityEvent OnGrounded, OffGrounded;
    private CharacterController Controller;

    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Controller.isGrounded)
        {
            OnGrounded.Invoke();
        }
        else
        {
            OffGrounded.Invoke();
        }

        CharacterMover.Move(controller);
        


        
        position.x = Input.GetAxis("Horizontal")*Speed*Time.deltaTime;

        
    }
}
