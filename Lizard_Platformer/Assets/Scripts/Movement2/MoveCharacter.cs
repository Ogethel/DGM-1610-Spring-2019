using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveCharacter : MonoBehaviour
{  
    public UnityEvent OnGrounded, OffGrounded;
    public MoveBase CharacterMover;
    
    private CharacterController controller;
    private Vector3 position;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            OnGrounded.Invoke();
        }
        else
        {
            OffGrounded.Invoke();
        }

        CharacterMover.Move(controller);



    }
}
