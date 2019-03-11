using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnFunctions : MonoBehaviour
{
    public int A;
    public int B;
    public int C;

    public Vector3 position;
    public CharacterController Controller;

    private int Add()
    {
        return A + B;
    }

    private int Subtract()
    {
        return A - B;
    }

    public Vector3 Move()
    {
        position.y = Input.GetAxis("Horizontal");
        Controller.Move(position);
        return position;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
