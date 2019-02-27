using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveCharacter : MonoBehaviour
{
    public float Speed = 3;
    public UnityEvent OnGrounded, OffGrounded;
    private CharacterController Controller;
    private Vector3 position;
    
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
        
        position.y = Input.GetAxis("Vertical")*Speed*Time.deltaTime;
        position.x = Input.GetAxis("Horizontal")*Speed*Time.deltaTime;
        
        Controller.Move(position);
    }
}
